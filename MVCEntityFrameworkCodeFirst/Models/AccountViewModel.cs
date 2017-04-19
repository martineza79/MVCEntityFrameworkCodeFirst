using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityFrameworkCodeFirst.Models
{
    public class AccountViewModel
    {
        public LoginEntity LoginEntityModel { get; set; } //LoginEntity property for LoginEntity class in MVCEFCodeFirstDbContext 
        public List<LoginEntity> ResultList { get; set; } 
    }
}