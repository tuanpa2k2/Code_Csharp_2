using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._9
{
    class NameException:Exception
    {
        public NameException(string ? message) : base(message)
        {

        }
    }
}
