using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Application
{

    /// <summary>
    /// Kullanıcıdan gelen isteğe cevap yollayan servis arayüzü 
    /// </summary>
    /// <typeparam name="TRequest"></typeparam> 
    /// <typeparam name="TResponse"></typeparam>
    public interface IApplicationService<in TRequest, out TResponse>
    {
        TResponse OnProcess(TRequest @request = default(TRequest));
    }
}
