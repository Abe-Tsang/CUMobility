using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUMobility.Models
{
    public class LogInModel
    {
        public bool LogIn(String info)
        {
            String[] infos = System.IO.File.ReadAllLines(@"C:\Users\Abraham\Desktop\CUMobility\usernameandpassword.txt");
            foreach(string s in infos)
            {
                if (info.Equals(s))
                {
                    return true;
                }
            }
            return false;
        }
        public bool LogInAdmin(String info)
        {
            String[] infos = System.IO.File.ReadAllLines(@"C:\Users\Abraham\Desktop\CUMobility\usernameandpassword.txt");
            if (info.Equals(infos[0]))
            {
                return true;
            }
            return false;
        }
    }
}
