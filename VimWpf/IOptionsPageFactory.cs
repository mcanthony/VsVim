﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vim.UI.Wpf
{
    public interface IOptionsPageFactory
    {
        IOptionsPage CreateOptionsPage();
    }
}
