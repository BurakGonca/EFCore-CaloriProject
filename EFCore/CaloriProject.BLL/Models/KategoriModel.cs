﻿using CaloriProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.BLL.Models
{
    public class KategoriModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public List<YiyecekModel> YiyecekModeller { get; set; } 


    }
}