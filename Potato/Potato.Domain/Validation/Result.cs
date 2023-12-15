using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato.Domain.Validation
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public T Value { get; set; }

        public Result(bool isSuccess, T value)
        {
            IsSuccess = isSuccess;
            Value = value;
        }
    }
}
