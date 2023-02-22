using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;

namespace partBproject
{
    public enum ContactStatus
    {
        [Description("In Progress")]
        InProgress,
        Treated,
        [Description("Not Treated")]
        NotTreated
    }

}
