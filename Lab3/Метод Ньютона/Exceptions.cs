using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_Ньютона
{
  class IntervalAException : Exception
  {
    public IntervalAException(string message) : base(message) { }
  }

  class IntervalBException : Exception
  {
    public IntervalBException(string message) : base(message) { }
  }

  class FuncException : Exception
  {
    public FuncException(string message) : base(message) { }
  }

  class AccuracyException : Exception 
  {
    public AccuracyException(string message) : base(message) { }
  }

  class DerivativeException : Exception
  {
    public DerivativeException(string message) : base(message) { }
  }
}
