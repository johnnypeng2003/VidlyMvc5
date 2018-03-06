using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMVC5.Models;

namespace VidlyMVC5.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}