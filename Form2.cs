using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVtest
{
    public partial class Form2 : Form
    {
        private string pathLop;
        private int sinhVienInfoLength;
        public Form2(string pathLop = "", int sinhVienInfoLength = 0)
        {
            this.pathLop = pathLop;
            this.sinhVienInfoLength = sinhVienInfoLength;

            InitializeComponent();
            this.MaximizeBox = false;
            addSVBtn.BackColor = Color.Lime;
            cancelBtn.BackColor = Color.PaleVioletRed;
        }

        private void addSVBtn_Click(object sender, EventArgs e)
        {

            var data = new string[sinhVienInfoLength];
            data[0] = mssvTextBox.Text;
            data[1] = hoTenTextBox.Text;
            data[2] = maLopTextBox.Text;
            data[3] = dToanTextBox.Text;
            data[4] = dAnhTextBox.Text;
            data[5] = dVanTextBox.Text;

            int flag = 1;
            for(int i = 0; i < data.Length; i++)
            {
                if (string.IsNullOrEmpty(data[i]))
                    flag = 0;
            }
            
            if (flag == 0)
            {
                MessageBox.Show("Missing data");
            }
            else
            {
                var sinhVienAdded = new SinhVien();
                bool checkDiem = sinhVienAdded.Nhap(data);

                if(checkDiem)
                {
                    string pathMaLop = "./Lop/" + maLopTextBox.Text + ".txt";

                    using (var sw = new StreamWriter(pathMaLop, true))
                    {
                        sw.AutoFlush = true;

                        for (int i = 0; i < data.Length; i++)
                        {
                            sw.WriteLine(data[i]);
                        }
                    }

                    MessageBox.Show("Added successfully");
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
