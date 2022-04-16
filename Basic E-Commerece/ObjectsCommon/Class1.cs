using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsCommon
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool is_admin { get; set; }

    }
}
