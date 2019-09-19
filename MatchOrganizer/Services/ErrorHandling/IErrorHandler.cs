using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ErrorHandling
{
    public interface IErrorHandler
    {
        void Handle(Exception exception);
    }
}
