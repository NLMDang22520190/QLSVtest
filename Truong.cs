using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVtest
{
    internal class Truong
    {
        private DirectoryInfo di;
        private FileInfo[] fi;
        private string pathLop;
        private string pathMaLop;
        private int sinhVienInfoLength;
        public Truong(string pathLop, int sinhVienInfoLength = 0, string pathMaLop = "")
        {
            this.pathLop = pathLop;
            di = new DirectoryInfo(pathLop);
            fi = di.GetFiles();
            this.pathMaLop = pathMaLop;
            this.sinhVienInfoLength = sinhVienInfoLength;
        }

        public void Removed(string mssv)
        {
            int flag = 0;
            int lineToDeleteStart = 0, linesAfterDelete;
            foreach (var finfo in fi)
            {
                pathMaLop = "./Lop/" + finfo.Name;
                string[] readAllLinesOfRemoved = File.ReadAllLines(pathMaLop);

                var currentLopOfRemoved = new Lop();
                currentLopOfRemoved.SL = readAllLinesOfRemoved.Length / sinhVienInfoLength;
                using (var sr = new StreamReader(pathMaLop))
                {
                    currentLopOfRemoved.Nhap(sr);
                    int mssvIndex = currentLopOfRemoved.TimTheoMssvIndex(mssv);
                    if (mssvIndex != -1)
                    {
                        //Console.WriteLine("sinh vien o lop " + finfo.Name);
                        lineToDeleteStart = mssvIndex * sinhVienInfoLength;
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    using (var sw = new StreamWriter(pathMaLop))
                    {

                        sw.AutoFlush = true;
                        linesAfterDelete = readAllLinesOfRemoved.Length - sinhVienInfoLength;

                        for (int i = 0; i < linesAfterDelete; i++)
                        {
                            if (i >= lineToDeleteStart)
                            {
                                sw.WriteLine(readAllLinesOfRemoved[i + sinhVienInfoLength]);
                            }
                            else if (i < lineToDeleteStart)
                                sw.WriteLine(readAllLinesOfRemoved[i]);
                        }

                    }
                    MessageBox.Show("Removed Successfully");
                    break;
                }
            }
            if (flag == 0)
                MessageBox.Show("Sinh Vien with MSSV " + mssv + " doesnt exist"); ;
        }

        public void Searched(string input)
        {
            if (int.TryParse(input, out int test)) //search theo mssv
            {
                var sinhVienCanTim = new SinhVien();
                foreach (var finfo in fi)
                {
                    pathMaLop = "./Lop/" + finfo.Name;
                    string[] readAllLinesOfSearch = File.ReadAllLines(pathMaLop);
                    var currentLopOfSearch = new Lop();
                    currentLopOfSearch.SL = readAllLinesOfSearch.Length / sinhVienInfoLength;
                    using (var sr = new StreamReader(pathMaLop))
                    {
                        currentLopOfSearch.Nhap(sr);
                        sinhVienCanTim = currentLopOfSearch.TimTheoMssv(input);
                    }
                    if (sinhVienCanTim != null)
                    {

                        //Console.WriteLine("Sinh vien o lop " + finfo.Name);
                        var Form5 = new Form5(pathLop, sinhVienInfoLength);
                        Form5.StartPosition = FormStartPosition.CenterScreen;

                        string[] labelsName = { "STT", "MaLop", "MSSV", "HoTen","DToan",
                                "DAnh", "DVan", "DTB"  };

                        Form5.AddLabelToForm(labelsName, 0);
                        Form5.AddLabelToForm(sinhVienCanTim.SinhVienDataToLine(0), 1);
                        Form5.SetFormSize(1);
                        Form5.Show();

                        sinhVienCanTim.Xuat();
                        break;
                    }

                }
                if (sinhVienCanTim == null)
                {
                    MessageBox.Show("Sinh Vien with MSSV " + input + " not found.");
                }
            }
            else // search theo ten
            {
                var dsSinhVienCanTim = new List<SinhVien>();
                foreach (var finfo in fi)
                {
                    pathMaLop = "./Lop/" + finfo.Name;
                    string[] readAllLinesOfSearch = File.ReadAllLines(pathMaLop);
                    var currentLopOfSearch = new Lop();
                    currentLopOfSearch.SL = readAllLinesOfSearch.Length / sinhVienInfoLength;
                    using (var sr = new StreamReader(pathMaLop))
                    {
                        currentLopOfSearch.Nhap(sr);
                        currentLopOfSearch.TimTheoTen(input.ToLower(), dsSinhVienCanTim);
                    }

                }
                if (dsSinhVienCanTim.Count > 0)
                {
                    Console.WriteLine("Tim thay");
                    for (int i = 0; i < dsSinhVienCanTim.Count; i++)
                        dsSinhVienCanTim[i].Xuat();
                }
                else
                    Console.WriteLine("Khong tim thay ten sinh vien");
            }
        }

        public void Exported(string input, string ePath)
        {
            string exportPath = ePath;
            pathMaLop = "./Lop/" + input + ".txt";
            int khoangCach1 = 15;
            int khoangCach2 = 10;
            int khoangCachSTT = Math.Max(0, khoangCach2 - 3);
            int khoangCachHoten = Math.Max(0, khoangCach1 - 5);
            int khoangCachMssv = Math.Max(0, khoangCach2 - 4);
            int khoangCachMaLop = Math.Max(0, khoangCach2 - 5);
            int khoangCachDToan = Math.Max(0, khoangCach2 - 5);
            int khoangCachDAnh = Math.Max(0, khoangCach2 - 4);
            int khoangCachDVan = Math.Max(0, khoangCach2 - 4);
            int khoangCachDTb = Math.Max(0, khoangCach2 - 3);
            string csSTT = $"STT{new string(' ', khoangCachSTT)}";
            string csHoten = $"HoTen{new string(' ', khoangCachHoten)}";
            string csMssv = $"Mssv{new string(' ', khoangCachMssv)}";
            string csMaLop = $"MaLop{new string(' ', khoangCachMaLop)}";
            string csDToan = $"DToan{new string(' ', khoangCachDToan)}";
            string csDAnh = $"DAnh{new string(' ', khoangCachDAnh)}";
            string csDVan = $"DVan{new string(' ', khoangCachDVan)}";
            string csDTb = $"DTB{new string(' ', khoangCachDTb)}";
            using (var sw = new StreamWriter(exportPath, true))
            {
                sw.Write(csSTT + csMaLop + csMssv + csHoten + csDToan + csDAnh + csDVan);
                sw.WriteLine(csDTb);
            }
            if (input == "all")
            {
                int i = 0;
                foreach (var finfo in fi)
                {
                    pathMaLop = "./Lop/" + finfo.Name;
                    string[] readAllLines = File.ReadAllLines(pathMaLop);
                    var currentLopOfExport = new Lop();
                    currentLopOfExport.SL = readAllLines.Length / sinhVienInfoLength;

                    using (var sr = new StreamReader(pathMaLop))
                    {
                        currentLopOfExport.Nhap(sr);
                    }

                    using (var sw = new StreamWriter(exportPath, true))
                    {
                        currentLopOfExport.XuatRaFileAll(sw, khoangCach1, khoangCach2, ref i);
                    }
                }
                Console.WriteLine("Xuat thanh cong");
            }

            else if (File.Exists(pathMaLop))
            {
                string[] readAllLines = File.ReadAllLines(pathMaLop);
                var currentLopOfExport = new Lop();
                currentLopOfExport.SL = readAllLines.Length / sinhVienInfoLength;
                using (var sr = new StreamReader(pathMaLop))
                {
                    currentLopOfExport.Nhap(sr);
                }

                using (var sw = new StreamWriter(exportPath, true))
                {
                    currentLopOfExport.XuatRaFile(sw, khoangCach1, khoangCach2);
                }
                Console.WriteLine("Xuat thanh cong");
            }
            else
            {
                Console.WriteLine("Sai cu phap hoac khong tim thay lop");
            }
        }

        public void Top(string input, string status)
        {
            var dsTatCaSinhVien = new List<SinhVien>(); // Luu tru tat ca sinh vien
            var dsSinhVienTop = new List<SinhVien>(); // Luu tru cac sinh vien thuoc top n

            foreach (var finfo in fi)
            {
                pathMaLop = "./Lop/" + finfo.Name;
                string[] readAllLinesOfTop = File.ReadAllLines(pathMaLop);
                var currentLopOfTop = new Lop();
                currentLopOfTop.SL = readAllLinesOfTop.Length / sinhVienInfoLength;

                using (var sr = new StreamReader(pathMaLop))
                {
                    currentLopOfTop.Nhap(sr);
                    currentLopOfTop.CopyVaoDS(dsTatCaSinhVien);
                }
            }
            int sLSV = dsTatCaSinhVien.Count; // lay so luong sinh vien hien co
            int n = int.Parse(input);

            if (n > sLSV)
            {
                Console.WriteLine("Top sinh vien khong the vuot qua so luong sinh vien hien co");
                goto end;
            }

            if (status.ToLower() == "true")
            {
                int firstMaxDiemIndex, secondMaxDiemIndex;
                do
                {
                    firstMaxDiemIndex = 0;
                    secondMaxDiemIndex = 0;
                    for (int j = 1; j < dsTatCaSinhVien.Count; j++)
                    {
                        if (dsTatCaSinhVien[j].DTB >= dsTatCaSinhVien[firstMaxDiemIndex].DTB)
                        {
                            secondMaxDiemIndex = firstMaxDiemIndex;
                            firstMaxDiemIndex = j;
                        }
                    }

                    dsSinhVienTop.Add(dsTatCaSinhVien[firstMaxDiemIndex]);

                    if ((dsSinhVienTop.Count >= n && dsTatCaSinhVien[firstMaxDiemIndex].DTB != dsTatCaSinhVien[secondMaxDiemIndex].DTB) || dsSinhVienTop.Count == sLSV)
                        break;

                    dsTatCaSinhVien.RemoveAt(firstMaxDiemIndex);
                } while (true);

                Console.WriteLine("Top " + n + " sinh vien co diem cao nhat");
            }
            else if (status.ToLower() == "false")
            {
                int firstMinDiemIndex, secondMinDiemIndex;
                do
                {
                    firstMinDiemIndex = 0;
                    secondMinDiemIndex = 0;
                    for (int j = 1; j < dsTatCaSinhVien.Count; j++)
                    {
                        if (dsTatCaSinhVien[j].DTB <= dsTatCaSinhVien[firstMinDiemIndex].DTB)
                        {
                            secondMinDiemIndex = firstMinDiemIndex;
                            firstMinDiemIndex = j;
                        }
                    }

                    dsSinhVienTop.Add(dsTatCaSinhVien[firstMinDiemIndex]);

                    if ((dsSinhVienTop.Count >= n && dsTatCaSinhVien[firstMinDiemIndex].DTB != dsTatCaSinhVien[secondMinDiemIndex].DTB) || dsSinhVienTop.Count == sLSV)
                        break;

                    dsTatCaSinhVien.RemoveAt(firstMinDiemIndex);
                } while (true);

                Console.WriteLine("Top " + n + " sinh vien co diem thap nhat");
            }
            else
            {
                Console.WriteLine("Loi cu phap");
                goto end;
            }

            for (int i = 0; i < dsSinhVienTop.Count; i++)
                dsSinhVienTop[i].Xuat();
            end:;
        }

        
    }
}
