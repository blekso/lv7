﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lv7.components
{
    class FileLogger : Logger
    {
        private string filePath;
        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public void Log(SimpleSystemDataProvider provider)
        {
            System.IO.StreamWriter writer =
           new System.IO.StreamWriter(this.filePath, true);
            writer.WriteLine(DateTime.Now + "-> CPU load: " +
           provider.CPULoad + " Available RAM: " + provider.AvailableRAM);
            writer.Close();
        }
    }

}
