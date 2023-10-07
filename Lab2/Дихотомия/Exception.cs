using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дихотомия
{
  class IntervalAException : Exception
  {
    public IntervalAException(string message) : base(message) {}
  }

  class IntervalBException : Exception
  {
    public IntervalBException(string message) : base(message) { }
  }

  class AccuracyException : Exception
  {
    public AccuracyException(string message) : base(message) { }
  }
}
