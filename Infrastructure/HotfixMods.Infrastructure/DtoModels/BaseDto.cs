﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotfixMods.Infrastructure.DtoModels
{
    public abstract class BaseDto
    {
        public BaseDto(string displayName)
        {
            DisplayName = displayName;
        }
        public string DisplayName { get; set; }
    }
}
