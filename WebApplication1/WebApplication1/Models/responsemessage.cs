using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Responsemessage
    {
        public long Id { get; set; }
        public long CD { get; set; }
        public string Message { get; set; }

        public virtual ICollection<ThanksCardResponse> ThanksCardResponses { get; set; }
    }
}
