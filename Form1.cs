namespace QLSVtest
{
    public partial class Form1 : Form
    {
        private string pathLop;
        private int sinhVienInfoLength;
        public Form1(string pathLop = "", int sinhVienInfoLength = 0)
        {
            this.pathLop = pathLop;
            this.sinhVienInfoLength = sinhVienInfoLength;
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            addBtn.Cursor = Cursors.Hand;
            rmBtn.Cursor = Cursors.Hand;
            topBtn.Cursor = Cursors.Hand;
            srchBtn.Cursor = Cursors.Hand;
            expBtn.Cursor = Cursors.Hand;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2(pathLop, sinhVienInfoLength);
            Form2.StartPosition = FormStartPosition.CenterParent;
            Form2.ShowDialog();
        }

        private void rmBtn_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3(pathLop, sinhVienInfoLength);
            Form3.StartPosition = FormStartPosition.CenterParent;
            Form3.ShowDialog();
        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            var Form4 = new Form4(pathLop, sinhVienInfoLength);
            Form4.StartPosition = FormStartPosition.CenterParent;
            Form4.ShowDialog();
        }

        private void topBtn_Click(object sender, EventArgs e)
        {
            var Form6 = new Form6(pathLop, sinhVienInfoLength);
            Form6.StartPosition = FormStartPosition.CenterParent;
            Form6.ShowDialog();
        }

        private void expBtn_Click(object sender, EventArgs e)
        {
            var Form7 = new Form7(pathLop, sinhVienInfoLength);
            Form7.StartPosition = FormStartPosition.CenterParent;
            Form7.ShowDialog();
        }
    }
}