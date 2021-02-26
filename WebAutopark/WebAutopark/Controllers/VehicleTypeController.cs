﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAutopark.BusinessLogic.Services.Base;
using WebAutopark.BusinessLogic.ViewModels;

namespace WebAutopark.Controllers
{
    public class VehicleTypeController : Controller
    {
        private readonly IVehicleTypeService _vehicleTypeService;
        public VehicleTypeController(IVehicleTypeService vehicleTypeService)
        {
            _vehicleTypeService = vehicleTypeService;
        }

        public async Task<IActionResult> ViewList()
        {
            var vehicleTypesList = await _vehicleTypeService.GetVehicleTypes();

            return View(vehicleTypesList);
        }
        // GET: VehicleTypeController/Details/5
        public async Task<IActionResult> View(int id)
        {
            var vehicleType = await _vehicleTypeService.GetVehicleTypeById(id);

            return View(vehicleType);
        }

        // GET: VehicleTypeController/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicleTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VehicleTypeViewModel viewModel)
        {
            await _vehicleTypeService.CreateVehicleType(viewModel);

            return RedirectToAction("ViewList");
        }

        // GET: VehicleTypeController/Edit/5
        public async Task<IActionResult> Update(int id)
        {
            var vehicleTypes = await _vehicleTypeService.GetVehicleTypeById(id);

            return View(vehicleTypes);
        }

        // POST: VehicleTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(VehicleTypeViewModel viewModel)
        {
            await _vehicleTypeService.UpdateVehicleType(viewModel);

            return RedirectToAction("ViewList");
        }

    }
}