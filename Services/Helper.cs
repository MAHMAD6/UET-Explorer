using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UET_Explorer.Services
{
    public static class Helper
    {
        public static string SeparateFirstWord(ref string name)
        {
            name = name.Trim();
            string[] nameParts = name.Split(" ");
            name = string.Join(" ", nameParts.Skip(1));
            return nameParts[0];
        }
    }
}
