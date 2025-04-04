using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json;

namespace Azureblue.ApplicationInsights.RequestLogging
{
    public class HeadersReader : IHeadersReader
    {
        public virtual string ReadRequestHeaders(HttpContext context)
        {
			var dictionary = new Dictionary<string, string>();
            foreach(var header in context.Request.Headers)
            {
				dictionary.Add(header.Key, header.Value.ToString());
			}

			return JsonSerializer.Serialize(dictionary);
        }
    }
}
