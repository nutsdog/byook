﻿using Newtonsoft.Json.Linq;
using System.Security.Claims;

namespace ByookWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ByookDbContext context;

        public ProductController(ByookDbContext context)
        {
            this.context = context;
        }

        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product model, IFormFile? file)
        {
            try
            {
                if(ModelState.IsValid)
                {

                }

                model.SellerId = User.Claims.FirstOrDefault(d => d.Type.Equals(ClaimTypes.NameIdentifier))!.Value;

                await context.Product!.AddAsync(model);

                return View(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}