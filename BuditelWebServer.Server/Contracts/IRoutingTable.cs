using BuditelWebServer.Server.HTTP;
using BuditelWebServer.Server.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServer.Server.HTTP_Request;

namespace BuditelWebServer.Server.Contracts
{
    public interface IRoutingTable
    {
        IRoutingTable Map(string url, Method method, Response response);
        IRoutingTable MapGet(string url, Response response);
        object MapGet(string v, TextResponse textResponse);
        IRoutingTable MapPost(string url, Response response);
    }
}