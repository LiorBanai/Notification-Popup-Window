﻿/*
 *	Created/modified in 2011 by Simon Baer
 *	
 *  Licensed under the Code Project Open License (CPOL).
 */

using System;
using System.Windows.Forms;

namespace DemoApp
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}