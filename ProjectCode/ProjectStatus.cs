﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace partBproject
{

    public enum ProjectStatus
    {
        [Description("In Process")]
        InProcess,
        Finished


    }
}
