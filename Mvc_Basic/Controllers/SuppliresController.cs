using AutoMapper;
using DomailEntity.Entities;
using EcommerceCore.Domain;
using Mvc_Basic.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace Mvc_Basic.Controllers
{
    public class SuppliresController : Controller
    {
        private EcommerceDbContext db = new EcommerceDbContext();
        // GET: Supplires
        public ActionResult Index()
        {
            var supplier = db.Suppliers.ToList();
            var supplierViewModel = Mapper.Map<IEnumerable<SupplierViewModel>>(supplier);
            return View(supplierViewModel);
        }

        // GET: Supplires/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Supplier supplier = new Supplier();
            if (supplier == null)
            {
                return HttpNotFound();
            }
            var supplier = Mapper.Map<SupplierViewModel>(Supplier);
            return View();
        }

        // GET: Supplires/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supplires/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplires/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Supplires/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplires/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Supplires/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
