﻿using BACampusApp.Entities.DbSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACampusApp.Dtos.ClassroomStudent
{
    public class ClassroomStudentCreateDto
    {
        public Guid StudentId { get; set; }
        public Guid ClassroomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        

    }
}
