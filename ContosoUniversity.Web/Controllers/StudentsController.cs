using ContosoUniversity.Application.DTOs;
using ContosoUniversity.Application.Services.Interfaces;
using System.Data;
using System.Net;
using System.Web.Mvc;

namespace ContosoUniversity.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: Students
        public ActionResult Index()
        {
            return View(_studentService.Get());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentDto student = _studentService.Get((int)id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EnrollmentDate,CreatedDate,UpdatedDate")] StudentDto student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _studentService.Insert(student);
                    return RedirectToAction("Index");
                }
            }
            catch(DataException ex)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentDto student = _studentService.Get((int)id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EnrollmentDate,CreatedDate,UpdatedDate")] StudentDto student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _studentService.Update(student);

                    return RedirectToAction("Index");
                }
            }
            catch(DataException ex)
            {
                // TODO log error
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }

            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }

            StudentDto student = _studentService.Get((int)id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _studentService.Delete((int)id);
            }
            catch(DataException ex)
            {
                // TODO Log the error
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }

            return RedirectToAction("Index");
        }

        // GET: Students/Statistics
        public ActionResult Statistics()
        {
            // TODO page that showing how many students have enrolled for each enrollment date

            return View();
        }
    }
}
