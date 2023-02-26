/// <summary>
/// Lab 1 Calculator Application 
/// Author: Shayan Zahedanaraki
/// Date: January 11, 2023; Revision: -
/// Source: Code based on the Intro to Windows Forms (WinForms) in .NET 6 tutorial at: https://www.youtube.com/watch?v=0zLZQesgV5o&t=4100s
/// EXternal Libraries: https://matheval.org/
/// </summary>

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}