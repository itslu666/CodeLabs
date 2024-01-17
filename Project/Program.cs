namespace Project
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
            ApplicationConfiguration.Initialize();

            LoginWindow lw = new LoginWindow();
            if (lw.ShowDialog() == DialogResult.OK)
            {
                // Wenn das Login erfolgreich war, erstelle eine Instanz deines MainWindow
                MainWindow mainWindow = new MainWindow();

                // Und hier rufst du Application.Run mit dem MainWindow auf
                Application.Run(mainWindow);
            }
        }
    }
}