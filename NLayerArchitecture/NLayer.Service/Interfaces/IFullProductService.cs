﻿using NLayer.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Interfaces
{
    public interface IFullProductService
    {
        void Add(FullProductAddDto fullProduct);
    }
}
