using System;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Builder;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Linq;

namespace Jander.HspServices.Middleware
{
    public class GzipMiddleware
    {
        RequestDelegate _next;

        public GzipMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Verifies that the calling client supports gzip encoding.
            if (!(from encoding in context.Request.Headers.GetValues("Accept-Encoding") ?? Enumerable.Empty<string>()
                  where encoding.Contains("gzip")
                  select encoding).Any())
            {
                await _next(context);
                return;
            }

            // Replaces the response stream by a memory stream
            // and keeps track of the real response stream.
            var body = context.Response.Body;
            context.Response.Body = new MemoryStream();

            try
            {
                await _next(context);

                // Verifies that the response stream is still a readable and seekable stream.
                if (!context.Response.Body.CanSeek || !context.Response.Body.CanRead)
                {
                    throw new InvalidOperationException("The response stream has been replaced by an unreadable or unseekable stream.");
                }

                // Determines if the response stream meets the length requirements to be gzipped.
                if (context.Response.Body.Length >= 4096)
                {
                    context.Response.Headers["Content-Encoding"] = "gzip";

                    // Determines if chunking can be safely used.
                    /*
                    if (String.Equals(context.Request.Protocol, "HTTP/1.1", StringComparison.Ordinal))
                    {
                        context.Response.Headers["Transfer-Encoding"] = "chunked";

                        // Opens a new GZip stream pointing directly to the real response stream.
                        using (var gzip = new GZipStream(body, CompressionMode.Compress, leaveOpen: false))
                        {
                            // Rewinds the memory stream and copies it to the GZip stream.
                            context.Response.Body.Seek(0, SeekOrigin.Begin);
                            await context.Response.Body.CopyToAsync(gzip, 81920);
                            
                        }

                        return;
                    }
                    */

                    // Opens a new buffer to determine the gzipped response stream length.
                    using (var buffer = new MemoryStream())
                    {
                        // Opens a new GZip stream pointing to the buffer stream.
                        using (var gzip = new GZipStream(buffer, CompressionMode.Compress, leaveOpen: true))
                        {
                            // Rewinds the memory stream and copies it to the GZip stream.
                            context.Response.Body.Seek(0, SeekOrigin.Begin);
                            await context.Response.Body.CopyToAsync(gzip, 81920);
                        }

                        // Rewinds the buffer stream and copies it to the real stream.
                        // See http://blogs.msdn.com/b/bclteam/archive/2006/05/10/592551.aspx
                        // to see why the buffer is only read after the GZip stream has been disposed.
                        buffer.Seek(0, SeekOrigin.Begin);
                        context.Response.ContentLength = buffer.Length;
                        await buffer.CopyToAsync(body, 81920);
                    }

                    return;
                }

                // Rewinds the memory stream and copies it to the real response stream.
                context.Response.Body.Seek(0, SeekOrigin.Begin);
                context.Response.ContentLength = context.Response.Body.Length;
                await context.Response.Body.CopyToAsync(body, 81920);
            }

            finally
            {
                // Restores the real stream in the environment dictionary.
                context.Response.Body = body;
            }
        }
    }

    public static class GzipMiddlewareExtensions
    {
        public static IApplicationBuilder UseGzip(this IApplicationBuilder app)
        {
            return app.UseMiddleware<GzipMiddleware>();
        }
    }

}