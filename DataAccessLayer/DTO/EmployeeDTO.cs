using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataAccessLayer.DTO
{
    public class EmployeeDTO
    {
        public List<DEPARTMENT> Departments { get; set; }
        public List<POSITION> Positions { get; set; }
    }
}
