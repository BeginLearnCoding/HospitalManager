using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PhongKham.Core.Entities;
using PhongKham.Core.Interfaces;
using PhongKham.WebApp.Services;

namespace PhongKham.WebApp.Pages.Manager
{
    public class MedicineModel : PageModel
    {
        private readonly MedicineService _medicineService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRazorRenderService _renderService;

        public MedicineModel(MedicineService medicineService, IUnitOfWork unitOfWork, IRazorRenderService renderService)
        {
            _medicineService = medicineService;
            _unitOfWork = unitOfWork;
            _renderService = renderService;

        }

        public IEnumerable<Medicine> Medicines { get; set; }
        public async Task OnGetAsync()
        {
            Medicines = await _medicineService.GetMedicinesListAsync();
        }
        public async Task<PartialViewResult> OnGetViewAllPartial()
        {
            Medicines = await _medicineService.GetMedicinesListAsync();
            return new PartialViewResult
            {
                ViewName = "_TableMedicine",
                ViewData = new ViewDataDictionary<IEnumerable<Medicine>>(ViewData, Medicines)
            };
        }
        public async Task<JsonResult> OnGetCreateOrEditAsync(int id = 0)
        {
            if (id == 0)
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEditMedicine", new Medicine()) });
            else
            {
                var thisMedicine = await _medicineService.GetMedicineById(id);
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEditMedicine", thisMedicine) });
            }
        }
        public async Task<JsonResult> OnPostCreateOrEditAsync(int id, Medicine medicine)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    await _medicineService.AddMedicineAsync(medicine);
                    await _unitOfWork.CompleteAsync();
                }
                else
                {
                    await _medicineService.UpdateMedicine(medicine);
                    await _unitOfWork.CompleteAsync();
                }
                Medicines = await _medicineService.GetMedicinesListAsync();
                var html = await _renderService.ToStringAsync("_TableMedicine", medicine);
                return new JsonResult(new { isValid = true, html = html });
            }
            else
            {
                var html = await _renderService.ToStringAsync("_CreateOrEditMedicine", medicine);
                return new JsonResult(new { isValid = false, html = html });
            }
        }
        public async Task<JsonResult> OnPostDeleteAsync(int id)
        {
            var medicine = await _medicineService.GetMedicineById(id);
            await _medicineService.DeleteMedicine(medicine);
            await _unitOfWork.CompleteAsync();
            Medicines = await _medicineService.GetMedicinesListAsync();
            var html = await _renderService.ToStringAsync("_TableMedicine", medicine);
            return new JsonResult(new { isValid = true, html = html });
        }
    }
}
