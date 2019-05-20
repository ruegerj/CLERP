using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Behavior
{
    public class PerformanceProfilerPipelineBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger<PerformanceProfilerPipelineBehaviour<TRequest, TResponse>> _logger;

        public PerformanceProfilerPipelineBehaviour(ILogger<PerformanceProfilerPipelineBehaviour<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, 
            CancellationToken cancellationToken, 
            RequestHandlerDelegate<TResponse> next)
        {
            TResponse result;

            _logger.LogDebug($"Get request [{DateTime.Now}:{DateTime.Now.Millisecond}], stopwatch started.");
            var stopwatch = Stopwatch.StartNew();

            result = await next();

            stopwatch.Stop();
            _logger.LogDebug($"Finished request [{DateTime.Now}], elapsed: {stopwatch.Elapsed}, {stopwatch.ElapsedMilliseconds}ms");

            return result;
        }
    }
}
