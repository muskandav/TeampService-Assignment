using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempService
{
    public class Temp
    {
        public static double CTF(double tempCel)
        {
            return (tempCel * 1.8) + 32;
        }

        public static double FTC(double tempFar)
        {
            return (tempFar - 32) / 1.8;
        }
    }
}