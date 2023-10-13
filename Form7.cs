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
    public partial class Form7 : Form
    {
        private string pathLop;
        private int sinhVienInfoLength;
        public Form7(string pathLop = "", int sinhVienInfoLength = 0)
        {
            this.pathLop = pathLop;
            this.sinhVienInfoLength = sinhVienInfoLength;
            InitializeComponent();
            this.MaximizeBox = false;
            lopTextBox.Visible = false;
            pathTextBox.ReadOnly = true;

            openBtn.BackColor = Color.Aqua;
            exportBtn.BackColor = Color.LimeGreen;
            cancelBtn.BackColor = Color.PaleVioletRed;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lopTextBox.Visible = true;
        }

        private void allBtn_CheckedChanged(object sender, EventArgs e)
        {
            lopTextBox.Visible = false;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
           
            using(SaveFileDialog fbd = new SaveFileDialog() { })
            {
                fbd.Filter = "txt fille (*.txt) | *.txt ";
                fbd.Title = "Save exported file";
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    pathTextBox.Text = fbd.FileName;
                }
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathTextBox.Text))
            {
                var TruongOfExport = new Truong(pathLop, sinhVienInfoLength);
                if(allBtn.Checked)
                {
                    TruongOfExport.Exported("all", pathTextBox.Text);
                }
                else
                    TruongOfExport.Exported(lopTextBox.Text, pathTextBox.Text);

            }
            else
                MessageBox.Show("Path cant be Null");
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
