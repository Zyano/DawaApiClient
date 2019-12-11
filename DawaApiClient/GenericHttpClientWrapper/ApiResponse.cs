using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Dawa.Api.Client.GenericHttpClientWrapper
{
    public class ApiResponse<T> where T : class, new()
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public string ResponsePhrase { get; set; }

        public T Result { get; set; }
    }
}
