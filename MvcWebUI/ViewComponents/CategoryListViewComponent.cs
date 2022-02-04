using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        //VİEWCOMPONENT'İ LAYOUTDA ÇAĞIRICAZ ÇÜNKÜ COMPONENT BİR SAYFADA İKİ FARKLI COMPONENT KULLANABİLİRİZ CATEGORY SABİT GELİCEK AYNI LAYOUT GİBİ
        private ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        //VİEW'İ DEFAULT İSMİNDE OLMASI GEREKİYOR
        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                CurrentCategory=Convert.ToInt32(HttpContext.Request.Query["category"])
            };
            return View(model);
        }
    }
}   
