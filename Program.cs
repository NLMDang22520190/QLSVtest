namespace QLSVtest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string pathLop = "./Lop"; //Lay path cua foler chua cac lop
            int sinhVienInfoLength = 6; // do dai thong tin sinh vien
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(pathLop,sinhVienInfoLength));
        }
    }
}