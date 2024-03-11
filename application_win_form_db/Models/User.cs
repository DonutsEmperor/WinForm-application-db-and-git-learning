﻿using System;
using System.Collections.Generic;

namespace application_win_form_db.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }

        public virtual Operator? Operator { get; set; }
    }
}
