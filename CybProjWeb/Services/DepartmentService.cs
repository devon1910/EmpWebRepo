﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CybProjWeb.Data;
using CybProjWeb.Entities;
using CybProjWeb.Inteface;
using Microsoft.EntityFrameworkCore;

namespace CybProjWeb.Services
{
    public class DepartmentService :IDepartment
    {
        private EmployeeDataContext _context;
        public DepartmentService(EmployeeDataContext context)
        {
            _context = context;
        }

        public void Add(Department dept)
        {
            dept.DateCreated = DateTime.Now;
            _context.Add(dept);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(Department dept)
        {
            //var existingdeptCount = _context.Departments.Contains(dept);

            var existingdeptCount = _context.Departments.Count(d => d.DeptName == dept.DeptName);
            var existingdeptCodeCount = _context.Departments.Count(d => d.DeptCode == dept.DeptCode);

            if (existingdeptCount == 0 && existingdeptCodeCount==0)
            {
                // Do your insert
                try
                {
                    await _context.AddAsync(dept);
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
                /*var existingdeptCount = _context.Departments.Count(
                d => d.DeptName == dept.deptName);*/

            }
            

            return false;
        }

        public async Task<bool> Delete(int Id)
        {
            // find the entity/object
            var dept = await _context.Departments.FindAsync(Id);

            if (dept != null)
            {
                _context.Departments.Remove(dept);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Department>> GetAll()
        {

            return await _context.Departments.Include(f => f.Faculty).ToListAsync();
        }

        public async Task<Department> GetById(int Id)
        {
            var dept = await _context.Departments.FindAsync(Id);

            return dept;
        }

        public async Task<bool> Update(Department dept)
        {
            var dep = await _context.Departments.FindAsync(dept.Id);
            if (dep != null)
            {
                dep.DeptName = dept.DeptName;
                dep.DeptCode = dept.DeptCode;
                dep.FacultyId = dept.FacultyId;
              //  dept.Faculty.FacultyName = dept.Faculty.FacultyName;
               
                await _context.SaveChangesAsync();
                return true;
            }

            return false;

        }
    }
}
