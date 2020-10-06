using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryTrue
{
    public class Class1
    {
        public bool cifri(string parol) {
            foreach (char m in parol)
            {
                if (!Char.IsDigit(m))
                    return true;
            }
            return false;
        }
        public bool UpReg(string parol)
        {
            foreach (char d in parol)
            {
                if (Char.IsUpper(d))
                    return true;
            }
            return false;
        }
        public bool Lenght(string parol) {
            if (parol.Length < 8)
                return false;
            else
                return true;
        }
    }
}
