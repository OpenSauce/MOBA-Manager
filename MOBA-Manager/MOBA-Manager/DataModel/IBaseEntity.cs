﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.DataModel
{
    interface IBaseEntity
    {
        string firstName { get; set; }
        string middleName { get; set; }
        string lastName { get; set; }
    }
}