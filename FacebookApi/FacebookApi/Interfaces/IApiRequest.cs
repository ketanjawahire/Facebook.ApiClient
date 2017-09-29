using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Interfaces
{
    public interface IApiRequest
    {
        TimeSpan GetElapsedTime();

        void AddUrlSegment(string name, string value);

        void AddHttpHeader(string name, string value);

        void AddCookie(string name, string value);
    }
}
