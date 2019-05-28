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
        public virtual Department DepartmentId { get; set; } //カラム
        public virtual Root RootId { get; set; }　//カラム
    }
}