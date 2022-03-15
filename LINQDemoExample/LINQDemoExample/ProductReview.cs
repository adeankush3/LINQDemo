using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoExample
{
    public class ProductReview
    {
        public int ProductId { get; set; }

        public int UserId { get; set; }

        public double Rating { get; set; }

        public String Review { get; set; }

        public bool IsLike { get; set; }

    }
}
