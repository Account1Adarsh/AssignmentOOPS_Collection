using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class MinimumPayException : Exception
    {
        public MinimumPayException(string msg):base(msg) { 
            
        }
    }
}
