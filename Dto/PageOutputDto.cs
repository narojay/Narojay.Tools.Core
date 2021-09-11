﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narojay.Tools.Core.Dto
{
    public class PageOutputDto<T>
    {
        public IReadOnlyCollection<T> Data { get; set; }
        public int TotalCount { get; set; }
    }
}
