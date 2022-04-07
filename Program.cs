using System;
using System.Configuration;
using System.Windows.Forms;
using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.repository;
using ConferenceManagementSystem.src.main.service;
using ConferenceManagementSystem.src.main.view;

namespace ConferenceManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            UserRepository<long, User> userRepository = new UserRepository<long, User>(conn);
            UserService userService = new UserService(userRepository);
            Intro introForm = new Intro(userService);
            Application.Run(introForm);
        }
    }
}
