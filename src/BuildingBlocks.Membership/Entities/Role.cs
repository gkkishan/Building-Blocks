﻿using System;
using System.Collections.Generic;

namespace BuildingBlocks.Membership.Entities
{
    public class Role
    {
        public Role()
        {
            Users = new List<string>();
        }

        public Guid RoleId { get; set; }
        public string ApplicationName { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

        public IEnumerable<string> Users { get; set; }
    }
}