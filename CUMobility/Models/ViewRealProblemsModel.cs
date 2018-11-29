using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUMobility.Models
{
    public class ViewRealProblemsModel
    {
        public String[] Problems()
        {
            String[] problems = System.IO.File.ReadAllLines(@"C:\Users\Abraham\Desktop\CUMobility\realproblems.txt");
            return problems;
        }
    }
}
