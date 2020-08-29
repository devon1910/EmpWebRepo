using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Data;
using CybProjWeb.Dtos;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using CybProjWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CybProjWeb.Enums;
using Microsoft.Extensions.Logging;

namespace CybProjWeb.Controllers
{
    public class AccountController : BaseController
    {
        private EmployeeDataContext _context;
        private readonly IAccount _account;
        
        private readonly SignInManager<Account> _signInManager;
        private readonly UserManager<Account> _userManager;
        private readonly ILogger<AccountController> logger;


        public AccountController(IAccount account, ILogger<AccountController> Logger, SignInManager<Account> signInManager,UserManager<Account> userManager, EmployeeDataContext context)
        {
           // _roleManager = roleManager;
            _account = account;
            _signInManager = signInManager;
            _userManager = userManager;
            logger = Logger;

            _context = context;


        }
        public IActionResult Login()
        {
           // ViewBag.role = _context.Roless.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                Alert("Login Unsuccesful!", NotificationType.error);
                ModelState.AddModelError("", "UserName/Password is incorrect");
                return View();
            }
            Account user = new Account();
           
           // user.UserName = login.;
            user.Email = login.Email;
           // user.RoleName = login.RoleName;


            var signin = await _account.LoginIn(login);

            if (signin)
            {

                Alert("Login successful.", NotificationType.success);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Alert("incorrect username or password", NotificationType.error);
                return View();
            }
        }
        

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
            //if User SignUp is successful
            var signUp = await _account.Signupp(user, u.Password);

              if (signUp)
              {
              
                    //Alert("Account Created successfully.", NotificationType.success);
                    return RedirectToAction("login", "Account");
              }
            else
            {
                Alert("Invalid Password or username", NotificationType.error);
            }
              return View();
          }

        [HttpGet]
        public  IActionResult SignUp()
        {
           // ViewBag.role = _context.Roless.ToList();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null && await _userManager.IsEmailConfirmedAsync(user))
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var passwordResetLink = Url.Action("ResetPassword", "Account",
                        new { email = model.Email, token = token }, Request.Scheme);
                    logger.Log(LogLevel.Warning, passwordResetLink);
                    Alert("User Edited successfully.", NotificationType.success);
                    return RedirectToAction("login", "Account");
                }
               
                Alert("A token has been successfully sent to your email", NotificationType.success);
                return RedirectToAction("login","Account");
            }
            return View(model);
                
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
