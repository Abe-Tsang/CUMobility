using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUMobility.Models
{
    public class ReportProblemModel
    {
        public void Problem(String newproblem)
        {
            String[] originallines= System.IO.File.ReadAllLines(@"C:\Users\Abraham\Desktop\CUMobility\problems.txt");
            System.IO.File.WriteAllLines(@"C:\Users\Abraham\Desktop\CUMobility\problems.txt", originallines);
            System.IO.File.AppendAllText(@"C:\Users\Abraham\Desktop\CUMobility\problems.txt", newproblem);
            //System.IO.File.AppendAllText(@"C:\Users\Abraham\Desktop\WriteLines.txt", Environment.NewLine);
        }

    }
}
