using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BookStore.Areas.Admin.Controllers
{

    [RouteArea("Admin")]
    public class EmployeeController : Controller
    {

        // GET: Admin/Employee
        EmployeeManager manager = new EmployeeManager(new EfEmployeeDal());
        MessageViewModel messageViewModel = new MessageViewModel();
        BookStoreContext context = new BookStoreContext();



        [Route("Personel")]
        [Route("Personel/Index")]
        public ActionResult Index()
        {

            var result = context.Database.SqlQuery<EmployeeViewModel>(@"SELECT  Employees.*, Departments.DepartmentName
                                                                        FROM Employees JOIN
                                                                        Departments ON Employees.DepartmentID = Departments.ID").ToList();


            return View(result);
        }


        [Route("Personel/YeniPersonel")]
        [HttpGet]
        public ActionResult New()
        {
            var list = context.Departments.ToList();
            ViewBag.Department = new SelectList(list, "ID", "DepartmentName");
            return View("SignUpForm", new Employee());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Employee employee)
        {


            if (employee.ID == 0)
            {
                var list = manager.GetAll();
                foreach (var item in list)
                {
                    if (employee.FullName == item.FullName)
                    {
                        messageViewModel.Status = false;
                        messageViewModel.LinkText = "Personel Listesi";
                        messageViewModel.Url = "/Admin/Personel";
                        messageViewModel.Message = "Bu personel zaten mevcut...";
                        TempData["message"] = messageViewModel;
                        ViewBag.image = employee.EmployeeImage;
                        var departments = context.Departments.ToList();
                        ViewBag.Department = new SelectList(departments, "ID", "DepartmentName");
                        TempData["message"] = messageViewModel;
                        return View("SignUpForm", new Employee());
                    }

                }

                if (employee.DepartmentID == 1)
                {
                    messageViewModel.Status = false;
                    messageViewModel.Message = "Yetkisiz departman seçimi!";
                    TempData["message"] = messageViewModel;
                    var departments = context.Departments.ToList();
                    ViewBag.Department = new SelectList(departments, "ID", "DepartmentName");
                    return View("SignUpForm", new Employee());
                }

                if (Path.GetFileName(Request.Files[0].FileName).Length > 0)
                {
                    var extension = Path.GetExtension(Request.Files[0].FileName);
                    var newFileName = employee.FullName + "-" + DateTime.Now.ToString("dd-MM-yyyy-H-mm") + extension;
                    var path = "~/Areas/Admin/Images/Employee/" + newFileName;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    employee.EmployeeImage = "/Areas/Admin/Images/Employee/" + newFileName;

                    ViewBag.image = employee.EmployeeImage;
                    employee.Status = true;
                    manager.Add(employee);
                    var departments = context.Departments.ToList();
                    ViewBag.Department = new SelectList(departments, "ID", "DepartmentName");

                    messageViewModel.Status = true;
                    messageViewModel.Message = employee.FullName + " personeli başarıyle eklendi...";
                    messageViewModel.LinkText = "Giriş Yap";
                    messageViewModel.Url = "/Admin/Girisyap";
                    TempData["message"] = messageViewModel;
                    return View("SignUpForm", new Employee());
                }
                else
                {
                    messageViewModel.Status = false;
                    messageViewModel.Message = "Personel resmi boş geçilemez!";
                    TempData["message"] = messageViewModel;
                    var departments = context.Departments.ToList();
                    ViewBag.Department = new SelectList(departments, "ID", "DepartmentName");
                    return View("SignUpForm", new Employee());
                }
            }
            else
            {
                var update = manager.GetById(employee.ID);

                if (update == null)
                {
                    return HttpNotFound();
                }

                var oldFullName = update.FullName;
                var oldEmail = update.Email;
                var oldPassword = update.Password;
                var oldDepartment = update.DepartmentID;
                string oldImage = update.EmployeeImage;

                var extension = Path.GetExtension(Request.Files[0].FileName);
                var newFileName = employee.FullName + "-" + "Update" + "-" + DateTime.Now.ToString("dd-MM-yyyy-H-mm") + extension;
                var path = "~/Areas/Admin/Images/Employee/" + newFileName;


                //if (oldDepartment != 1 | !User.IsInRole("Yönetici"))
                //{
                //    messageViewModel.Status = false;
                //    messageViewModel.LinkText = "Personel Listesi";
                //    messageViewModel.Url = "/Admin/Personel";
                //    messageViewModel.Message = "Yetkisiz departman seçimi!";
                //    var departments = context.Departments.ToList();
                //    ViewBag.Department = new SelectList(departments, "ID", "DepartmentName");
                //    TempData["message"] = messageViewModel;
                //    return View("SignUpForm", new Employee());
                //}

                if (Path.GetFileName(Request.Files[0].FileName) != "")
                {
                    if (!oldImage.Contains("http"))
                    {
                        string fullPath = Request.MapPath("~" + oldImage);
                        if (System.IO.File.Exists(fullPath))
                        {
                            System.IO.File.Delete(fullPath);
                        }
                    }
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    employee.EmployeeImage = "/Areas/Admin/Images/Employee/" + newFileName;

                }

                if (employee.FullName == oldFullName && employee.Email == oldEmail && employee.Password == oldPassword && employee.DepartmentID == oldDepartment && extension == "")
                {
                    messageViewModel.Status = false;
                    messageViewModel.LinkText = "Personel Listesi";
                    messageViewModel.Url = "/Admin/Personel";
                    messageViewModel.Message = "Herhangi bir değişiklik yapılmadı...";
                    var departments = context.Departments.ToList();
                    ViewBag.Department = new SelectList(departments, "ID", "DepartmentName");
                    TempData["message"] = messageViewModel;
                    return View("SignUpForm", new Employee());

                }
                else
                {
                    if (extension == "")
                        employee.EmployeeImage = oldImage;
                    //employee.DepartmentID = oldDepartment;
                    manager.Update(employee);
                    messageViewModel.Status = true;
                    messageViewModel.Message = "Bilgiler başarıyla güncellendi...";
                    TempData["message"] = messageViewModel;

                }
            }

            return RedirectToAction("Index", "Personel");
        }



        [Route("Personel/Guncelle/{id}")]
        public ActionResult Update(int id)
        {
            var model = manager.GetById(id);

            ViewBag.updateDepartman = model.DepartmentID;

            var deneme = User.Identity.Name;
            var list = context.Departments.ToList();
            ViewBag.Department = new SelectList(list, "ID", "DepartmentName");

            if (model == null)
                return HttpNotFound();

            if (User.IsInRole("Yönetici"))
            {
                return View("SignUpForm", model);

            }
            else if (model.Email != deneme)
            {
                messageViewModel.Status = false;
                messageViewModel.Message = "Yetkisiz işlem...";
                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "Personel");
            }

            if (model.DepartmentID == 1 && !User.IsInRole("Yönetici"))
            {
                messageViewModel.Status = false;
                messageViewModel.Message = "Yetkisiz işlem...";
                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "Personel");
            }





            return View("SignUpForm", model);
        }

        [Authorize(Roles = "Yönetici")]
        [Route("Personel/Sil/{id}")]
        public ActionResult Delete(int id)
        {
            var delete = manager.GetById(id);
            if (delete == null)
                return HttpNotFound();
            string oldImage = delete.EmployeeImage;
            if (!oldImage.Contains("http"))
            {
                string fullPath = Request.MapPath("~" + oldImage);
                if (System.IO.File.Exists(fullPath))
                {
                    System.IO.File.Delete(fullPath);
                }
            }

            manager.Delete(delete);
            messageViewModel.Status = true;
            messageViewModel.Message = delete.FullName + " isimli personel silindi...";
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Personel");

        }

    }
}