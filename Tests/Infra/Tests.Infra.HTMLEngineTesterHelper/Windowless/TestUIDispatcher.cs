﻿using System;
using System.Threading.Tasks;
using Neutronium.Core.WebBrowserEngine.Window;

namespace Tests.Infra.WebBrowserEngineTesterHelper.Windowless
{
    public class TestUIDispatcher : IDispatcher
    {
        public Task RunAsync(Action act)
        {
            act();
            return Task.FromResult<object>(null);
        }

        public void Run(Action act)
        {
            act();
        }

        public Task<T> EvaluateAsync<T>(Func<T> compute)
        {
            return Task.FromResult(compute());
        }

        public T Evaluate<T>(Func<T> compute)
        {
            return compute();
        }

        public bool IsInContext() 
        {
            return true;
        }
    }
}