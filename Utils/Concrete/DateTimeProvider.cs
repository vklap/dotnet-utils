using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Abstract;

namespace Utils.Concrete
{

    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime CurrentDateTime
        {
            get { return DateTime.UtcNow; }
        }
    }
}
