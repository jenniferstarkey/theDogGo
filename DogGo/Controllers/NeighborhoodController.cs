using DogGo.Models;
using DogGo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Controllers
{
    public class NeighborhoodController : Controller
    {
        // GET: NeighborhoodController
        private INeighborhoodRepository _hoodRepo;
        public NeighborhoodController(IConfiguration config)
        {
            _hoodRepo = new NeighborhoodRepository(config);
        }
        public ActionResult Index()
        {
            List<Neighborhood> hood = _hoodRepo.GetAll();
            return View(hood);
        }

        // GET: NeighborhoodController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NeighborhoodController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NeighborhoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: NeighborhoodController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NeighborhoodController/Edit/5
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

        // GET: NeighborhoodController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NeighborhoodController/Delete/5
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
