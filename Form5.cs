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

    public partial class Form5 : Form
    {
        private string pathLop;
        private int sinhVienInfoLength;
        public Form5(string pathLop = "", int sinhVienInfoLength = 0)
        {
            this.pathLop = pathLop;
            this.sinhVienInfoLength = sinhVienInfoLength;
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public void AddLabelToForm(string[] linesToAdd, int j)
        {
            for (int i = 0; i < linesToAdd.Length; i++)
            {
                var currentLabel = new Label();
                currentLabel.Text = linesToAdd[i];
                if (i >= 4)
                    currentLabel.Location = new Point(75 + 100 * i, 10 + 30 * j);
                else
                    currentLabel.Location = new Point(50 + 100 * i, 10 + 30 * j);

                this.Controls.Add(currentLabel);
            }
        }

        public void SetFormSize(int i)
        {
            this.Width = 900;
            this.Height = 100 + 50 * i;
        }
    }
}
