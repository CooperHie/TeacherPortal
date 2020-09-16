﻿using System.Collections.Generic;
using TeacherDirectory.Models;
using System.Linq;

namespace TeacherDirectory.Services
{
    public class MockTeacherRepository : ITeacherRepository
    {
        private List<Teacher> _teacherList;
        
        public MockTeacherRepository()
        {
            _teacherList = new List<Teacher>()
            {
                new Teacher() { ID = 1, FirstName = "Cooper", LastName = "Hiebendaal", TeacherCode = "HIE", Department = Dept.Sports,
                    Email = "porkhunt@gmail.com", PhotoPath = "John.png" },
                new Teacher() { ID = 2, FirstName = "Malhar", LastName = "Gohel", TeacherCode = "GHL", Department = Dept.Science,
                    Email = "john@pragimtech.com", PhotoPath = "User.jpg" },
                new Teacher() { ID = 3, FirstName = "Aziz", LastName = "Patel", TeacherCode = "PAT", Department = Dept.Mathematics,
                    Email = "sara@pragimtech.com", PhotoPath = "User.jpg" },
                new Teacher() { ID = 4, FirstName = "Shayen", LastName = "Kesha", TeacherCode = "KES", Department = Dept.Technology,
                    Email = "david@pragimtech.com", PhotoPath = "User.jpg" },
            };
        }
        
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _teacherList;
        }

        public Teacher GetTeacher(int ID)
        {
            return _teacherList.FirstOrDefault(e => e.ID == ID);
        }

        public Teacher Update(Teacher updatedTeacher)
        {
            Teacher teacher = _teacherList.FirstOrDefault(e => e.ID == updatedTeacher.ID);

            if(teacher != null)
            {
                teacher.FirstName = updatedTeacher.FirstName;
                teacher.Email = updatedTeacher.Email;
                teacher.Department = updatedTeacher.Department;
                teacher.PhotoPath = updatedTeacher.PhotoPath;
            }

            return teacher;
        }
    }
}
