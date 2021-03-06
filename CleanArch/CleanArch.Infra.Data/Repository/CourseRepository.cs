﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctxUniversity;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctxUniversity = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctxUniversity.Courses;
        }
    }
}
