﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _认识事物_CHSTRAS_091作业_
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CHSTRAS_091_Work());
        }
    }
}
