﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core
{
    public class RateLimitReachedException : Exception
    {
        public RateLimitReachedException(string message) : base(message)
        {
        }
    }
}
