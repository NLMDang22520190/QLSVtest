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
    public partial class Form3 : Form
    {
        private string pathLop;
        private int sinhVienInfoLength;
        public Form3(string pathLop = "", int sinhVienInfoLength = 0)
        {
            this.pathLop = pathLop;
            this.sinhVienInfoLength = sinhVienInfoLength;
            InitializeComponent();
            this.MaximizeBox = false;
            rmBtn.BackColor = Color.LimeGreen;
            cancelBtn.BackColor = Color.PaleVioletRed;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter MSSV to remove Sinh Vien");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rmBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mssvTextBox.Text))
            {
                var TruongOfRemove = new Truong(pathLop, sinhVienInfoLength);
                TruongOfRemove.Removed(mssvTextBox.Text);
                //MessageBox.Show("Removed Successfully");
            }
            else
                MessageBox.Show("MSSV cant be Null");
           
        }
    }
}
