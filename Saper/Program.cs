using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Saper
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists("setup.ini"))
                File.AppendAllText("setup.ini", "9 9 10 1");
            if (!File.Exists("records.ini"))
                File.AppendAllText("records.ini", "Новичок 99 99 Anonim\nОпытный 99 99 Anonim\nЭлита 99 99 Anonim");
            StreamReader fsetup = new StreamReader("setup.ini");
            string SetStr = fsetup.ReadLine();
            string[] Set = SetStr.Split(' ');
            fsetup.Close();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(Int32.Parse(Set[0]), Int32.Parse(Set[1]), Int32.Parse(Set[2]), Int32.Parse(Set[3])));
        }
    }
}
