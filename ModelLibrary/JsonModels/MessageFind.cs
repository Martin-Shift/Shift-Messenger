﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.JsonModels
{
    public class MessageFind 
    {
        public string FromLogin { get; set; } = string.Empty;
        public string ToLogin { get; set; } = string.Empty;
    }
}
