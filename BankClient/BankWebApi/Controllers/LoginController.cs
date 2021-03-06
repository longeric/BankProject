﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;
using BankWebApi.ViewModels;
using System.Threading;
using System.Web.Http.Cors;

namespace BankWebApi.Controllers
{
    [EnableCorsAttribute("*", "*", "*")]
    public class LoginController : ApiController
    {
        [RequireHttps]
        [BasicAuthentication]
        public IEnumerable<LogIn> Get()
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            
            using (bankEntities be = new bankEntities())
            {
                //List<loginViewModel> listofLogin = new List<loginViewModel>();
                //loginViewModel loginUser = new loginViewModel();
                //foreach (var user in be.LogIns)
                //{
                //    loginUser.LoginID = user.LoginID;
                //    loginUser.Password = user.Password;
                //    loginUser.Name = user.Name;
                //    listofLogin.Add(loginUser);
                //}
                return be.LogIns.ToList();
            }

            

            //try
            //{
            //    using (bankEntities bankentity = new bankEntities())
            //    {
            //        //bankentity
            //        var message = Request.CreateResponse(HttpStatusCode.OK);
            //        message.Headers.Location = new Uri(Request.RequestUri + "string");
            //        return Request.CreateResponse(HttpStatusCode.Created, "");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);           
            //}
        }
    }
}
