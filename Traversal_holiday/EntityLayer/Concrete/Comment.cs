using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int commentId { get; set; }

        public string commetUser { get; set; }

        public DateTime commetDate { get; set; }

        public string commetContent { get; set; }

        public bool commetStatus { get; set; }

        public string commetMail { get; set; }

        public int destinationId { get; set; }

        public Destination Destination { get; set; }
    }
}
