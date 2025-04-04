using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Azureblue.ApplicationInsights.RequestLogging
{
    public interface IHeadersReader
    {
        public string ReadRequestHeaders(HttpContext context);
    }
}
