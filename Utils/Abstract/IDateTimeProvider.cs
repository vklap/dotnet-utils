using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Abstract
{
    public interface IDateTimeProvider
    {
        DateTime CurrentDateTime { get; }
    }
}
