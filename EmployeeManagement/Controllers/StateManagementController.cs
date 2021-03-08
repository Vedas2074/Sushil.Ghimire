using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

public class StateManagementController : Controller
{
    public ViewResult First()
    {
        //server side
        //1.Tempdata
        TempData["x"] = "This is string";//set the temp data
        ViewData["x"] = 234;
        ViewBag.age = 22;
        //2.session
        HttpContext.Session.SetInt32("dob", 234);
        //client side
        //1.cookies
        var username = "sushil ghimire";
        CookieOptions options = new CookieOptions();
        options.Expires = DateTime.Now.AddHours(1);
        Response.Cookies.Append("user", username);
        
        return View();
    }
    public ViewResult Second(string name, int age)//2.Query string
    {
        var users = Request.Cookies["user"];
        var x = TempData["x"];//read the temp data
        return View("Second",users);
    }
    [HttpPost]
    public ViewResult Second(string id)//hidden fields
    {
        var x = TempData["x"];//not read the second(string id) because already read the second(string name,int age)
        return View();
    }
}