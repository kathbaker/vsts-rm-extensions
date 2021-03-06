﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.DistributedTask.WebApi;
using VstsServerTaskHelper.Core.Contracts;

namespace VstsServerTaskHelper.SampleAzureFunction
{
    public class SampleTaskExecutionHandler : ITaskExecutionHandler
    {
        public async Task<ITaskExecutionHandlerResult> ExecuteAsync(ITaskLogger taskLogger, CancellationToken cancellationToken)
        {
            taskLogger.Log("Inside my sample task execution handler");

            return await Task.FromResult(new TaskExecutionHandlerResult {Result = TaskResult.Succeeded});
        }

        public void CancelAsync(ITaskLogger taskLogger, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
