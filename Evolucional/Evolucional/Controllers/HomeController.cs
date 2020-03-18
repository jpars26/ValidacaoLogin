using Evolucional.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClosedXML.Excel;

namespace Evolucional.Controllers
{
    public class HomeController : Controller
    {
       

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

    

        [HttpPost]
        public ActionResult AddAluno() {

            using (AlunosDataBaseEntities ab = new AlunosDataBaseEntities()) {

                for (int i = 1; i < 1000; i++) {
                    string query = "INSERT INTO ALUNOS (NOME) VALUES (NEWID())";
                    aluno userAluno = ab.alunos.SqlQuery(query).SingleOrDefault();
                }
               

           //    if (addaluno == null) {
           //         return HttpNotFound();
              //  }
                return View(userAluno);
            }
        }



    }
}