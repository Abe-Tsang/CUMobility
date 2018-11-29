using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUMobility.Models
{
    public class ViewProblemsModel
    {
        public String[] Problems()
        {
            String[] problems = System.IO.File.ReadAllLines(@"C:\Users\Abraham\Desktop\CUMobility\problems.txt");
            return problems;
        }
    }
}
