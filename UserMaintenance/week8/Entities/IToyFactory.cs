﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week8.Abstractions;

namespace week8.Entities
{
    public class IToyFactory : Abstractions.IToyFactory
    {
        public Abstractions.Toy CreateNew()
        {
            return new Toy();
        }
    }
}
