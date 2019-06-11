using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class ThanksCard
    {
        public long Id { get; set; }
        public long CD { get; set; }
        public long FromId { get; set; }
        public virtual User From { get; set; }
        public long ToId { get; set; }
        public virtual User To { get; set; }
        public string Title { get; set; }
        public long Date　{ get; set; }
        public string Body { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }


        public virtual ICollection<ThanksCardResponse> ThanksCardResponses { get; set; }


    }
}
