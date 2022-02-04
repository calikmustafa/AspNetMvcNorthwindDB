﻿
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int category)
        {
            var model = new ProductListViewModel//BUNU MODELE ATMAMIZIN SEBEBİ İLERDE BAŞKA BİR ŞEY İSTEDİKLERİNDE VİEVE TEK BİR TANE BİR ŞEY GÖNDEREBİLİYORUZ O YÜZDEN BAŞKA BİR CLASA ATADIK
            {
                Products =category>0?_productService.GetByCategory(category):
                _productService.GetAll()
            };
            return View(model);
        }
    }
}