﻿using System;

namespace Durandal2UserMaint.Models
{
    public class UserGridModel
    {
        public string UserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastPasswordChange { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
    }
}