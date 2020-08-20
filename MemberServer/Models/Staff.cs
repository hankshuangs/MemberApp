using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MemberApp.Models
{
    public class Staff
    {
        public int Sid { get; set; }
        [Key]
        public string Staff_Id { get; set; }
        public string Store_Id { get; set; }
        public string Staff_Name { get; set; }
        public string Staff_Password { get; set; }
        public string Staff_Level { get; set; }
        public string Layer { get; set; }
        public string LeaveDate { get; set; }
        public string Staff_Created_Datetime { get; set; }
        public string Staff_Altered_Datetime { get; set; }
    }
}
