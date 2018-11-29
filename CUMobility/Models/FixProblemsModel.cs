using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUMobility.Models
{
    public class FixProblemsModel
    {
        public List<bool> SelectedProblems { get; set; }
        public FixProblemsModel()
        {
            SelectedProblems = new List<bool>();
        }
        public String[] Problems()
        {
            String[] problems = System.IO.File.ReadAllLines(@"C:\Users\Abraham\Desktop\CUMobility\realproblems.txt");
            return problems;
        }
        public void RemainingProblems(bool[] SelectedProblems)
        {
            String[] problems = System.IO.File.ReadAllLines(@"C:\Users\Abraham\Desktop\CUMobility\realproblems.txt");
            for (int i = 0; i < problems.Length; i++)
            {
                if (SelectedProblems[i]) // if problem is checked, delete
                {
                    problems[i] = "";
                }
                else // else continue
                {
                    continue;
                }
            }
            problems = problems.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            System.IO.File.WriteAllLines(@"C:\Users\Abraham\Desktop\CUMobility\realproblems.txt", problems);
        }
    }
}
