using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication1.Controllers
{
    class Context : DbContext
    {

        static Context()
        {
            Database.SetInitializer<Context>(new MyContextInitializer());
        }

        public DbSet<pos> poss { get; set; }
        public Context()
            : base("Con1")
        { }
    }

    class MyContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context db)
        {
            pos p1 = new pos { pos_name = "Официант", pos_salary = 15000 };
            pos p2 = new pos { pos_name = "Администратор", pos_salary = 40000 };
            db.poss.Add(p1);
            db.poss.Add(p2);
            db.SaveChanges();
        }
    }

    class pos
    {
        [Key]
        public int ID_pos { get; set; }//код должности
        public string pos_name { get; set; }//название должности
        public double pos_salary { get; set; }//ставка по должности
        public pos()
        {

        }
    }

    public class posController : Controller
    {
        // GET: pos
        Context db = new Context();
        [HttpGet]
        public ActionResult GetPos()
        {
            var ppos = db.poss.ToList();
            db.SaveChanges();
            return View(ppos);
        }
    }
}
