﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyWebApp1.Models;
using UdemyWebApp1.ViewModels;

namespace UdemyWebApp.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context=new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Cutomers.Include(c => c.MembershipType ).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Cutomers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            else return View(customer);
        }
    }
}