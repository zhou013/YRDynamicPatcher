﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPatcher
{
    public class Program
    {
        static Program()
        {
            DllMain();
        }

        private static void DllMain()
        {
#if DEBUG
            System.Windows.Forms.MessageBox.Show("Attach Me", "Dynamic Patcher");
#endif
            var patcher = new Patcher();
            string workDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DynamicPatcher");
            patcher.Init(workDir);
            patcher.StartWatchPath(workDir);
        }
    }
}
