using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Олимпиадные_сортировки
{
  class ExcelException : Exception
  {
    public ExcelException(string message) : base(message) { }
  }

  class ListException : Exception 
  {
    public ListException(string message) : base(message) { } 
  }
}
