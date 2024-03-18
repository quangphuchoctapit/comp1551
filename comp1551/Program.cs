using static comp1551.UserClass;

namespace comp1551
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


            // when the application is initially run, it first check if in the database, there is at least 1 result by this mysql syntax: 
            // SELECT COUNT(*) FROM User WHERE Role = 'admin', for more information, ctrl+Click InsertAdminIfNotExists in this below: system.AdminManage.InsertAdminIfNotExists(); 
            UoGSystem system = new UoGSystem();
            system.AdminManage.InsertAdminIfNotExists();

            // after that, the application WILL OPEN Login form
            Application.Run(new Login());
        }
    }
}
