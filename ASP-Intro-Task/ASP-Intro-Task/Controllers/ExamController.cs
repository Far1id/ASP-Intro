using ASP_Intro_Task.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Intro_Task.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            List<Exam> exams = new List<Exam>
            {
                new Exam(1, "jASJS",36),
                new Exam(2, "asdasd",26),
                new Exam(3, "sdffd",37),
                new Exam(4, "jASsdfsdJS",86)

            };

            ViewBag.Exams = exams;

            return View();
        }

        public IActionResult Detail(int id)
        {
            List<Exam> exams = new List<Exam>
            {
                new Exam(1, "jASJS",36),
                new Exam(2, "asdasd",26),
                new Exam(3, "sdffd",37),
                new Exam(4, "jASsdfsdJS",86)

            };

            Exam exam = exams.Find(x => x.Id == id);

            ViewBag.Exm = exam;

            return View();
        }
    }
}
