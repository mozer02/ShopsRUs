using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Application
{
    public interface IApplicationService<in TRequest, out TResponse>
    {
        TResponse OnProcess(TRequest @request = default(TRequest));
    }
}
