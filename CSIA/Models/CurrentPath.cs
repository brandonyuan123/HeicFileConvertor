﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIA.Models
{
    class CurrentPath
    {
        private static string loc = string.Empty;
        public static string GetCurrentPath()
        {
            loc = Directory.GetCurrentDirectory();

            loc = loc.Substring(0, loc.IndexOf("\\bin"));

            return loc;
        }

        public static string GetDbasePath()
        {
            loc = GetCurrentPath() + "\\Dbase";

            return loc;
        }
    }
}
