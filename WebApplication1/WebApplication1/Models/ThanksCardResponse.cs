using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ThanksCardResponse
    {
        public long Id { get; set; }
        public long ThanksCardId { get; set; }
        public ThanksCard ThanksCard { get; set; }
        public long ResponsemessageId { get; set; }
        public Responsemessage Responsemessage { get; set; }
    }
}
