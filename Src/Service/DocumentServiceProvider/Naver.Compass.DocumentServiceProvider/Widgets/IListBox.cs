﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naver.Compass.Service.Document
{
    public interface IListBox : IListBase
    {
        bool AllowMultiple { get; set; }
    }
}
