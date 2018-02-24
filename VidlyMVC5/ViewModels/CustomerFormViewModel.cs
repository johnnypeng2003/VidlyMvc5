using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMVC5.Models;

namespace VidlyMVC5.ViewModels
{
    public class CustomerFormViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}