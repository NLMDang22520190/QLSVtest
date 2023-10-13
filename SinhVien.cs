using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVtest
{
    public class SinhVien
    {
        private string hoten;
        private string mssv;
        private string maLop;
        private string loaiSv;
        private float dToan;
        private float dAnh;
        private float dVan;
        private float dTB;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public string Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        public string LoaiSv
        {
            get { return loaiSv; }
            set { loaiSv = value; }
        }

        public float DToan
        {
            get { return dToan; }
            set { dToan = value; }
        }

        public float DAnh
        {
            get { return dAnh; }
            set { dAnh = value; }
        }

        public float DVan
        {
            get { return dVan; }
            set { dVan = value; }
        }

        public float DTB
        {
            get { return dTB; }
            set { dTB = value; }
        }

        public SinhVien(string hoten = "", string mssv = "", string malop = "", string loaiSv = "", float dToan = 0, float dAnh = 0, float dVan = 0, float dTB = 0)
        {
            this.hoten = hoten;
            this.mssv = mssv;
            this.maLop = malop;
            this.loaiSv = loaiSv;
            this.dToan = dToan;
            this.dAnh = dAnh;
            this.dVan = dVan;
            this.DTB = dTB;
        }

        public void Nhap(StreamReader sr)
        {
            Mssv = sr.ReadLine();
            Hoten = sr.ReadLine();
            MaLop = sr.ReadLine();
            DToan = float.Parse(sr.ReadLine());
            DAnh = float.Parse(sr.ReadLine());
            DVan = float.Parse(sr.ReadLine());
            DTB = (float)Math.Round((DToan + DVan + DAnh) / 3,2);
        }

        public bool Nhap(string[] line)
        {
            mssv = line[0];
            hoten = line[1];
            maLop = line[2];
            try
            {
                if (float.TryParse(line[3], out dToan) && float.TryParse(line[4], out dAnh) && float.TryParse(line[5], out dVan))
                {
                    if (dToan < 0 || dToan > 10 || dAnh < 0 || dAnh > 10 || dVan < 0 || dVan > 10)
                    { throw new ArgumentOutOfRangeException(); }
                }
                else
                    throw new ArgumentOutOfRangeException();

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Wrong Point Input");
                return false;
            }
            return true;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Hoten: {0}", hoten);
            Console.WriteLine("MSSV: {0}", mssv);
            Console.WriteLine("Ma lop: {0}", maLop);
            //Console.WriteLine("Loai sv: {0}", loaiSv);
            Console.WriteLine("Diem toan: {0}", dToan);
            Console.WriteLine("Diem anh: {0}", dAnh);
            Console.WriteLine("Diem van: {0}", dVan);
            Console.WriteLine("Diem trung binh: {0}", dTB);
        }

        public void XuatRaFile(StreamWriter sw, int khoangCach1, int khoangCach2)
        {
            int khoangCachHoten = Math.Max(0, khoangCach1 - hoten.Length);
            int khoangCachMssv = Math.Max(0, khoangCach2 - mssv.Length);
            int khoangCachMaLop = Math.Max(0, khoangCach2 - maLop.Length);
            int khoangCachDToan = Math.Max(0, khoangCach2 - dToan.ToString().Length);
            int khoangCachDAnh = Math.Max(0, khoangCach2 - dAnh.ToString().Length);
            int khoangCachDVan = Math.Max(0, khoangCach2 - dVan.ToString().Length);
            int khoangCachDTb = Math.Max(0, khoangCach2 - dTB.ToString().Length);
            string csHoten = $"{hoten}{new string(' ', khoangCachHoten)}";
            string csMssv = $"{mssv}{new string(' ', khoangCachMssv)}";
            string csMaLop = $"{maLop}{new string(' ', khoangCachMaLop)}";
            string csDToan = $"{dToan}{new string(' ', khoangCachDToan)}";
            string csDAnh = $"{dAnh}{new string(' ', khoangCachDAnh)}";
            string csDVan = $"{dVan}{new string(' ', khoangCachDVan)}";
            string csDTb = $"{dTB}{new string(' ', khoangCachDTb)}";
            sw.Write(csMaLop + csMssv + csHoten + csDToan + csDAnh + csDVan);
            sw.WriteLine(csDTb);
        }

        public string[] SinhVienDataToLine(int i)
        {
            string[] a = {(i+1).ToString(), maLop, mssv, hoten, 
            dToan.ToString(), dAnh.ToString(), dVan.ToString(), dTB.ToString()};
            return a;
        }
    }
}

