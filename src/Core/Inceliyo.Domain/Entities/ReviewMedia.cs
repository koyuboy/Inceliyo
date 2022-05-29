using Inceliyo.Domain.Common;
using Inceliyo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Domain.Entities
{
    public class ReviewMedia : BaseEntity
    {
        public MediaType MediaType { get; set; }
        public Guid ReviewId { get; set; }
        public int MediaLocation { get; set; }
        public String Path { get; set; }
        public DateTime UploadAt { get; set; }

        public Review Review { get; set; }
    }
}
