using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;

namespace BankWebApi.Controllers
{
    public class LoginController : ApiController
    {

        public HttpResponseMessage Get(string username, string password)
        {
            try
            {
                using (bankEntities bankentity = new bankEntities())
                {
                    //bankentity
                    var message = Request.CreateResponse(HttpStatusCode.OK);
                    message.Headers.Location = new Uri(Request.RequestUri + "string");
                }
            }
            catch(Exception ex)
            {
                Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
