using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVtest
{
    public class Lop
    {
        private List<SinhVien> dssv;
        //private string maLop;
        private int sL;

        public List<SinhVien> Dssv
        {
            get { return dssv; }
            set { dssv = value; }
        }

        public int SL
        {
            get { return sL; }
            set { sL = value; }
        }

        public Lop(int sL = 0)
        {
            this.sL = sL;
            this.dssv = new List<SinhVien>();
        }

        public void Nhap(StreamReader sr)
        {
            SinhVien s;
            for (int i = 0; i < sL; i++)
            {
                s = new SinhVien();
                s.Nhap(sr);
                dssv.Add(s);
            }
        }

        public void Xuat()
        {
            for (int i = 0; i < dssv.Count; i++)
                dssv[i].Xuat();
        }

        public int TimTheoMssvIndex(string value)
        {
            for (int i = 0; i < dssv.Count; i++)
            {
                if (dssv[i].Mssv == value)
                {
                    Console.WriteLine("Tim thay");
                    return i;
                }
            }
            return -1;
        }

        public SinhVien TimTheoMssv(string value)
        {
            for (int i = 0; i < dssv.Count; i++)
            {
                if (dssv[i].Mssv == value)
                {
                    Console.WriteLine("Tim thay");
                    return dssv[i];
                }
            }
            return null;
        }

        public void TimTheoTen(string value, List<SinhVien> s)
        {
            for (int i = 0; i < dssv.Count; i++)
            {
                if (dssv[i].Hoten == value)
                {
                    s.Add(dssv[i]);
                }
            }
        }

        public void CopyVaoDS(List<SinhVien> s)
        {
            for (int i = 0; i < dssv.Count; i++)
                s.Add(dssv[i]);
        }

        public void XuatRaFile(StreamWriter sw, int khoangCach1, int khoangCach2)
        {
            for (int i = 0; i < dssv.Count; i++)
            {
                int khoangCachStt;
                if (i < 10)
                    khoangCachStt = Math.Max(0, khoangCach2 - 1);
                else
                    khoangCachStt = Math.Max(0, khoangCach2 - 2);

                string csStt = $"{i + 1}{new string(' ', khoangCachStt)}";
                sw.Write(csStt);
                dssv[i].XuatRaFile(sw, khoangCach1, khoangCach2);
            }
        }

        public void XuatRaFileAll(StreamWriter sw, int khoangCach1, int khoangCach2, ref int j)
        {
            for (int i = 0; i < dssv.Count; i++)
            {
                int khoangCachStt;
                if (j + 1 < 10)
                    khoangCachStt = Math.Max(0, khoangCach2 - 1);
                else
                    khoangCachStt = Math.Max(0, khoangCach2 - 2);

                string csStt = $"{j + 1}{new string(' ', khoangCachStt)}";
                sw.Write(csStt);
                dssv[i].XuatRaFile(sw, khoangCach1, khoangCach2);
                j++;
            }
        }
    }
}
