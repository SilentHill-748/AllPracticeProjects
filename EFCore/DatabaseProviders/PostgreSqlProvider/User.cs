using System;
using System.Collections.Generic;

#nullable disable

namespace PostgreSqlProvider
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
