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
    public partial class Form6 : Form
    {
        private string pathLop;
        private int sinhVienInfoLength;
        public Form6(string pathLop = "", int sinhVienInfoLength = 0)
        {
            this.pathLop = pathLop;
            this.sinhVienInfoLength = sinhVienInfoLength;
            InitializeComponent();
            this.MaximizeBox = false;
            topBtn.BackColor = Color.LimeGreen;
            cancelBtn.BackColor = Color.PaleVioletRed;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter N to output Top N Sinh Vien");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void topBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(topTextBox.Text))
            {
                var TruongOfTop = new Truong(pathLop, sinhVienInfoLength);
                if (highBtn.Checked)
                {
                    TruongOfTop.Top(topTextBox.Text, "true");
                }
                else if (lowBtn.Checked)
                {
                    TruongOfTop.Top(topTextBox.Text, "false");
                }
                else
                    MessageBox.Show("Please check the box");
                
            }
            else
                MessageBox.Show("N cant be Null");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
