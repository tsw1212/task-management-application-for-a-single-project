﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface ITaskInList
    {
        BO.TaskInList read(int id);
         IEnumerable<BO.TaskInList> ReadAll(Func<BO.TaskInList, bool>? filter = null);

    }
}
