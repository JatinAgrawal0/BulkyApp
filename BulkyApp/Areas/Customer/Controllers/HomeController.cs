using System.Reflection.Metadata;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bulky.Models;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using Bulky.Utility;

namespace BulkyApp.Areas.Customers.Controllers;
[Area("Customer")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;


    public HomeController(ILogger<HomeController> logger , IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
        return View(productList);
    }

    public IActionResult Details(int id)
    {
        ShoppingCart cart = new()
        {
            Product = _unitOfWork.Product.GetFirstOrDefault(u => u.ProductId == id,includeProperties: "Category"),
            count = 1,
            ProductId = id
        };
        return View(cart);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize]
    public IActionResult Details(ShoppingCart shoppingCart)
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
        shoppingCart.ApplicationUserId = userId;

        ShoppingCart cartFromDb =  _unitOfWork.ShoppingCart.GetFirstOrDefault
                                    (u=> u.ApplicationUserId == userId && 
                                    u.ProductId == shoppingCart.ProductId);
        if(cartFromDb!= null)
        {
            cartFromDb.count += shoppingCart.count;
            _unitOfWork.ShoppingCart.Update(cartFromDb);
            _unitOfWork.Save();
           }
        
        else
        {
             _unitOfWork.ShoppingCart.Add(shoppingCart);
             _unitOfWork.Save();
              HttpContext.Session.SetInt32(SD.SessionCart, _unitOfWork.ShoppingCart.GetAll
                                    (u => u.ApplicationUserId == userId).Count());
        
        }

        TempData["success"] = "Cart Updated Successfully";
        
        return RedirectToAction(nameof(Index));
        
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
