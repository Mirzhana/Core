﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace ControllerAndActions.Infrastructure
{
    public class CustomHtmlResult : IActionResult
    {
        public string Content { get; set; }
        public Task ExecuteResultAsync(ActionContext context) {
            context.HttpContext.Response.StatusCode = 200;
            context.HttpContext.Response.ContentType = "text/html";
            byte[] content = Encoding.ASCII.GetBytes(Content);
            return context.HttpContext.Response.Body.WriteAsync(content,
            0, content.Length);
        }
    }
}
