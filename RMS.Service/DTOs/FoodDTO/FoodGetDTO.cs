﻿using Microsoft.AspNetCore.Http;
using RMS.Service.DTOs.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.FoodDTO
{
    public class FoodGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public List<ProductGetDTO> Products { get; set; }
        public string File { get; set; }
    }
}
