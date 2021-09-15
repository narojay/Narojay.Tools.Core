using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narojay.Tools.Core.Dto
{
    /// <summary>
    /// 分页入参
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageInputDto<T> : PageInputBaseDto
    {
        public T Condition { get; set; }
    }

 

    public class PageInputDto : PageInputBaseDto
    {

    }
}
