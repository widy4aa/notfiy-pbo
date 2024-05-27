namespace notfiy
{
    using Core;
    using notfiy.Views.Login;
    using notfiy.Views.Todolist;

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

            SystemSingleton.Instance.ViewManager.MainForm = mainForm;
            //mainForm.Controls.Add(new LoginControl());
            mainForm.Controls.Add(new TodolistControl());

            Application.Run(mainForm);
        }
    }
}