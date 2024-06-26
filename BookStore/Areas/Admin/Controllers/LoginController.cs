﻿using BookStore.Areas.Admin.ViewModel;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BookStore.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    public class LoginController : Controller
    {
        // GET: Admin/Login
        BookStoreContext c = new BookStoreContext();
        MessageViewModel messageViewModel = new MessageViewModel();

        [Route("Girisyap")]
        [Route("Girisyap/Index")]
        [Route("")]
        public ActionResult Index()
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            return View();
        }


        [HttpPost]
        public ActionResult AdminLogin(Employee employee)
        {
            var result = c.Employees.FirstOrDefault(x => x.Email == employee.Email && x.Password == employee.Password);
            if (result != null)
            {
                FormsAuthentication.SetAuthCookie(result.Email, false);
                Session["Name"] = result.FullName;
                Session["Department"] = result.Department.DepartmentName;
                Session["Email"] = result.Email;

                Session["Image"] = result.EmployeeImage;


                Session["ID"] = result.ID;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                var result2 = c.Employees.FirstOrDefault(x => x.Email == employee.Email);
                if (result2 == null)
                {
                    messageViewModel.Status = false;
                    messageViewModel.Message = "E-mail adresinizi hatalı girdiniz...";
                    TempData["message"] = messageViewModel;
                }
                else
                {
                    messageViewModel.Status = false;
                    messageViewModel.Message = "Şifreyi hatalı girdiniz...";
                }

                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "Login");
            }
        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            //Session.Abandon();
            messageViewModel.Status = true;
            messageViewModel.Message = "Başarıyla çıkış yaptınız...";
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Login");
        }


    }
}