using System;
using UnityEngine;
using UnityEngine.Networking;

public class Request
{
    public static void GET(string url, Action<string> completedCallback)
    {
        UnityWebRequestAsyncOperation operation = UnityWebRequest.Get(url).SendWebRequest();

        operation.completed += (obj)=>
        {
            if(operation.webRequest.result == UnityWebRequest.Result.ConnectionError)
                Debug.LogError("[RequestGET] ConnectionError");
            else
                completedCallback?.Invoke(operation.webRequest.downloadHandler.text);

            operation.webRequest.Dispose();
        };
    }
}
