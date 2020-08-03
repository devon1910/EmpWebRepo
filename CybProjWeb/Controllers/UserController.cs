using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Data;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using static CybProjWeb.Enums.Enum;

namespace CybProjWeb.Controllers
{
    [Authorize(Roles = "User")]
    public class UserController : BaseController
    {
        private EmployeeDataContext _context;
        private IUser _user;
        private IDepartment _dept;
        private IFaculty _fac;
        private IGrade _grade;
       // private IState _state;
        public UserController(IUser user, IDepartment dept, IFaculty fac, IGrade grade,EmployeeDataContext context)
        {
            _dept = dept;
            _fac = fac;
            _user = user;
            _context = context;
            _grade = grade;
           // _state = state;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _user.GetAll();
            
            if (model != null)
            {
                ViewBag.state = _context.States.ToList();
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User u)
        {
            var createUser = await _user.AddAsync(u);
            //two options for steph, using a fresh view or using the lga/state format
           
            if (createUser)
            {
                Alert("User created successfully.", NotificationType.success);
              //  var steph = u.Grade.Level;
                return RedirectToAction("Index","Home");
            }
            else
            {
                Alert("User not created!", NotificationType.error);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var dept = await _dept.GetAll();
            var fac = await _fac.GetAll();
            var gradeName = await _grade.GetAll();
            var gradeLevel = await _grade.GetAll();
            var gradeStep = await _grade.GetAll();
            
            //var lga = _context.LGAs.ToList();

            
            //
            //

            var deptList = dept.Select(d => new SelectListItem()
            {
                Value = d.Id.ToString(),
                Text = d.DeptName
            });
            var facList = fac.Select(f => new SelectListItem()
            {
                Value = f.Id.ToString(),
                Text = f.FacultyName
            });
            var gradeListName = gradeName.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.GradeName
            });
            var gradeListLevel = gradeLevel.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.Level
            });
            var gradeListStep = gradeStep.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.Step
            });
           // ViewBag.lga = lgaList;
            ViewBag.state = _context.States.ToList();
            ViewBag.gradeName = gradeListName;
            ViewBag.gradeLevel = gradeListLevel;
            ViewBag.gradeStep = gradeListStep;
            ViewBag.dept = deptList;
            ViewBag.fac = facList;
           
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {

            var deleteUser = await _user.Delete(id);
            if (deleteUser)
            {
                Alert("User Deleted successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("User not Deleted!", NotificationType.error);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User u)
        {
            var editUser = await _user.Update(u);
            if (editUser && ModelState.IsValid)
            {
                Alert("User Edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("User not Edited!", NotificationType.error);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editUser = await _user.GetById(id);
            if (editUser == null)
            {
                return RedirectToAction("Index");
            }
            return View(editUser);
        }

        public IActionResult Cancel()
        {
            return RedirectToAction("Index", "User");
        }

        public JsonResult getLGAbyId(int id)
        {
            List<LGA> list= new List<LGA>();
            list = _context.LGAs.Where(a => a.State.Id == id).ToList();
            list.Insert(0, new LGA { Id = 0, Name = "Please select LGA" });
            return Json(new SelectList(list, "Id", "Name"));
        }
    }
}
