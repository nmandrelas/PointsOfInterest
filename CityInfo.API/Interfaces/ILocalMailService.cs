﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Interfaces
{
    public interface ILocalMailService
    {
        void Send(string mailTo, string subject, string message);
    }
}
