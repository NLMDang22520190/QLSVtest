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
    public partial class Form4 : Form
    {
        private string pathLop;
        private int sinhVienInfoLength;
        public Form4(string pathLop = "", int sinhVienInfoLength = 0)
        {
            this.pathLop = pathLop;
            this.sinhVienInfoLength = sinhVienInfoLength;
            InitializeComponent();
            srchBtn.BackColor = Color.LimeGreen;
            cancelBtn.BackColor = Color.PaleVioletRed;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(srchTextBox.Text))
            {
                var TruongOfSearch = new Truong(pathLop, sinhVienInfoLength);
                TruongOfSearch.Searched(srchTextBox.Text);
            }
            else
                MessageBox.Show("Searched info cant be Null");
          
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
