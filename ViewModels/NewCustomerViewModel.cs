using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdemyWebApp1.Models;

namespace UdemyWebApp1.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}