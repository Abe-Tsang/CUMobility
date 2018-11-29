using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CUMobility.Models;

namespace CUMobility.Controllers
{
    public class HomeController : Controller
    {
        static bool loggedin = false;
        static bool isloggedinadmin = false;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoggedInIndex()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public ActionResult ProblemReporting()
        {
            return View(new ReportProblemModel());
        }
        
        [HttpPost]
        public ActionResult ProblemReporting(String PL, String PT)
        {
            ReportProblemModel rpm = new ReportProblemModel();
            rpm.Problem(PL + " " + PT);
            return RedirectToAction("LoggedInIndex");
        }

        public ActionResult ProblemsViewing()
        {
            ViewProblemsModel vpm = new ViewProblemsModel();
            String[] problems = vpm.Problems();
            return View(problems);
        }

        public ActionResult LoggingIn()
        {
            return View(new LogInModel());
        }

        [HttpPost]
        public ActionResult LoggingIn(String UN, String PW)
        {
            LogInModel lim = new LogInModel();
            isloggedinadmin = lim.LogInAdmin(UN + " " + PW);
            loggedin = lim.LogIn(UN + " " + PW);
            if (loggedin == true)
            {
                return RedirectToAction("LoggedInIndex");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        public ActionResult ProblemsChecking()
        {
            if(isloggedinadmin == true)
            {
                CheckProblemsModel cpm = new CheckProblemsModel();
                String[] problems = cpm.Problems();
                for (int i = 0; i < problems.Length; i++) {
                    cpm.SelectedProblems.Add(false);
                }
                ViewData["Problems"] = problems;
                return View(cpm);
            }
            else
            {
                return RedirectToAction("LoggedInIndex");
            }
        }
        
        [HttpPost]
        public ActionResult ProblemsChecking(bool[] SelectedProblems)
        {
            CheckProblemsModel cpm = new CheckProblemsModel();
            cpm.RealProblems(SelectedProblems);
            return RedirectToAction("LoggedInIndex");
        }

        public ActionResult ProblemsFixing()
        {
            if (isloggedinadmin == true)
            {
                FixProblemsModel fpm = new FixProblemsModel();
                String[] problems = fpm.Problems();
                for (int i = 0; i < problems.Length; i++)
                {
                    fpm.SelectedProblems.Add(false);
                }
                ViewData["Problems"] = problems;
                return View(fpm);
            }
            else
            {
                return RedirectToAction("LoggedInIndex");
            }
        }

        [HttpPost]
        public ActionResult ProblemsFixing(bool[] SelectedProblems)
        {
            FixProblemsModel fpm = new FixProblemsModel();
            fpm.RemainingProblems(SelectedProblems);
            return RedirectToAction("LoggedInIndex");
        }
        public ActionResult RealProblemsViewing()
        {
            ViewRealProblemsModel vrpm = new ViewRealProblemsModel();
            String[] problems = vrpm.Problems();
            return View(problems);
        }
        /*
        public ActionResult GivingReward()
        {

        }
        */
    }
}
