﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ConfiguringApps.Infrastructure
{
    public class BrowserTypeMiddleware
    {
        private RequestDelegate nextDelegate;
        public BrowserTypeMiddleware(RequestDelegate next) {
            nextDelegate = next;

        }

        public async Task Invoke(HttpContext httpContext) {
            httpContext.Items["EdgeBrowser"] = httpContext.Request.Headers["User-Agent"].Any(m => m.ToLower().Contains("fox"));
            await nextDelegate.Invoke(httpContext);
        }

    }
}
