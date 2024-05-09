﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaMVC.Core.Models
{
    public class Feature: BaseEntity
    {
        public string Icon { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
