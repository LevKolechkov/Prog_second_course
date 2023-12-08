using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интегралы
{
  public class IntervalAException : Exception
  {
    public IntervalAException(string message) : base(message) { }
  }

  public class IntervalBException : Exception
  {
    public IntervalBException(string message) : base(message) { }
  }

  public class FuncException : Exception
  {
    public FuncException(string message) : base(message) { }
  }

  public class AccuracyException : Exception
  {
    public AccuracyException(string message) : base(message) { }
  }

  public class DerivativeException : Exception
  {
    public DerivativeException(string message) : base(message) { }
  }
}
