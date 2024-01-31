﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.BL.Data;
using University.BL.Models;

namespace University.BL.Repositories.Implements
{
    class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(UniversityContext universityContext): base(universityContext)
        {

        }
    }
}
