﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Config
    {
        public static string APIServer { get; } = ConfigurationHelper.AppSetting("APIServer");


    }
}
