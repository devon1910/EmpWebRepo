using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Dtos;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using CybProjWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static CybProjWeb.Enums.Enum;

namespace CybProjWeb.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IAccount _account;
        
        private readonly SignInManager<Account> _signInManager;
        private readonly UserManager<Account> _userManager;
        

        public AccountController(IAccount account, SignInManager<Account> signInManager, UserManager<Account> userManager)
        {
            _account = account;
            _signInManager = signInManager;
            _userManager = userManager;


        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
               // Alert("Login Unsuccesful!", NotificationType.error);
                ModelState.AddModelError("", "UserName/Password is incorrect");
                return View();
            }
            var k=login.Email;
            var signin = await _account.LoginIn(login);
            if (signin)
            {
               // Alert("Login successful.", NotificationType.success);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        //////////

         [HttpPost]
          public async Task<IActionResult> SignUp(UserDto u)
          {
              if (!ModelState.IsValid)
              {
                 // Alert("Sign Up Unsuccesful!", NotificationType.error);
                  ModelState.AddModelError("", "UserName/Password is incorrect");
                  return View();
              }
              Account user = new Account();
              user.UserName = u.Username;
              user.Email = u.Email;
              user.RoleName = u.RoleName;
            var signUp = await _account.Signupp(user, u.Password);

              if (signUp)
              {
               var signUpp = await _userManager.AddToRoleAsync(user, user.RoleName);
                if (signUpp.Succeeded)
                {
                    //Alert("Account Created successfully.", NotificationType.success);
                    return RedirectToAction("Index", "Home");
                }
                return View();
                
              }
              return View();
          }
        [HttpGet]
        public  IActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
