using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narojay.Tools.Core.Dto
{
    public class PageInputDto<T> : PageInputBaseDto
    {
        public T Condition { get; set; }
    }

 

    public class PageInputDto : PageInputBaseDto
    {

    }
}
