﻿using CaloriProject.DAL.Repostory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.DAL.Entities
{
    public class Ogun : Entity
    {
        
        public string OgunAdi { get; set; }

        public override string ToString()
        {
            return OgunAdi;
        }

    }
}
