﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication3;

namespace BullsandCows2._0_win_
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }

            catch (GenerateException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }
    }
}
        
    
