﻿using Microsoft.JSInterop;

namespace SLK.XClinic.WebApp;

public class JsPromiseHandler<T>
{
    public TaskCompletionSource<T> tcs { get; set; }

    [JSInvokable]
    public void SetResult(T result)
    {
        tcs.SetResult(result);
    }

    [JSInvokable]
    public void SetError(string error)
    {
        tcs.SetException(new Exception(error));
    }
}