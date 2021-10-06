using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narojay.Tools.Core.Dto
{
    /// <summary>
    /// 分页基础入参
    /// </summary>
    public class PageInputBaseDto
    {
        public int PageIndex { get; set; } = 1;

        public int PageSize { get; set; } = 10;
    }
}
