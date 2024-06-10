namespace notfiy
{
    using Core;
    using notfiy.Views.Login;
    using notfiy.Views.Todolist;
    using notfiy.Views;
    using notfiy.Views.Other;
    using notfiy.Views.Homepage;

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

        MainForm mainForm = new MainForm();

        // Tempat Konfigurasi Database
        string host = "pg-notify-pbo-pbo-notify.i.aivencloud.com";
        string port = "15854";
        string username = "avnadmin";
        string password = "AVNS_IPBEyWnremMh1XJk-Oi";
        string database = "defaultdb";
        string sslMode = "Require";
        string trustServerCertificate = "true";

        string connectionString = $"Host={host};Port={port};Username={username};Password={password};Database={database};SSL Mode={sslMode};Trust Server Certificate={trustServerCertificate}";
        //string connectionString = "Host=localhost:5050;Username=postgres;Password=noxzan123;Database=notify_pbo;";


        SystemSingleton.Instance.EnableDatabase(connectionString);
        SystemSingleton.Instance.ViewManager.MainForm = mainForm;

            //mainForm.Controls.Add(new TodolistControl());
            //mainForm.Controls.Add(new HomepageControl());
            //mainForm.Controls.Add(new HomepageControl());
            mainForm.Controls.Add(new LoginControl());


            Application.Run(mainForm);
            //Application.Run(new LoginUnitTesterForm());
        }
    }
}