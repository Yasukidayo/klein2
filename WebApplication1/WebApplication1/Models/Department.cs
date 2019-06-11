using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Department
    {
        public long Id { get; set; }
        public long CD { get;  set; }
        public string Name { get; set; }
       
       
        public long? ParentId { get; set; } //?をつけることによってNULLが入るようになる
        public virtual Department Parent { get; set; }
     

    }
}
