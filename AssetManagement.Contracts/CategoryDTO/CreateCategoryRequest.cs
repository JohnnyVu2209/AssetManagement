﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.CategoryDTO
{
    public class CreateCategoryRequest
    {
        public string Name { get; set; }
        public string Prefix { get; set; }
    }
}