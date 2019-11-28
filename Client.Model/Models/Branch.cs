using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Model.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string Location { get; set; }
        public string ManagerName { get; set; }
        public double Budget { get; set; }
    }
}
