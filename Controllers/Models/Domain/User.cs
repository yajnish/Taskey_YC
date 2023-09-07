using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taskey.Controllers.Models.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public bool IsManager { get; set; }

    }
}