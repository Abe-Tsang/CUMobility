using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUMobility.Models
{
    public class CheckProblemsModel
    {
        public List<bool> SelectedProblems { get; set; }
        public CheckProblemsModel()
        {
            SelectedProblems = new List<bool>();
        }
        public String[] Problems()
        {
            String[] problems = System.IO.File.ReadAllLines(@"C:\Users\Abraham\Desktop\CUMobility\problems.txt");
            return problems;
        }
        public void RealProblems(bool[] SelectedProblems)
        {
            String[] problems = System.IO.File.ReadAllLines(@"C:\Users\Abraham\Desktop\CUMobility\problems.txt");
            List<String> RealProblems = new List<string>();
            for (int i = 0; i < problems.Length; i++)
            {
                if (SelectedProblems[i]) // if problem is checked, delete
                {
                    RealProblems.Add(problems[i]);
                    problems[i] = "";

                }
                else // else continue
                {
                    continue;
                }
            }
            problems = problems.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            System.IO.File.WriteAllLines(@"C:\Users\Abraham\Desktop\CUMobility\problems.txt", problems);
            String[] realproblems = RealProblems.ToArray();
            System.IO.File.WriteAllLines(@"C:\Users\Abraham\Desktop\CUMobility\realproblems.txt", realproblems);
        }
    }
}
