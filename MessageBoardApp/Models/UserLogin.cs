using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MessageBoardApp.Models
{
    public class UserLogin
    {
        public string UserId{get; set;}
        public string UserName{get; set;}
        public string MessageContent{get; set;}
    };
}