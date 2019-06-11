using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
    public class User
    {
        public long Id { get; set; }  //主キー
        public long CD { get; set; }
        public string Name { get; set; } //カラム
        public string Password { get; set; } //カラム
        public bool IsAdmin { get; set; }
        public long? DepartmentId { get; set; }
        public virtual Department Department { get; set; } //カラム
   
    }
}