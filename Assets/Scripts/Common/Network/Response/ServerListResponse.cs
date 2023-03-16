using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ServerListResponse
{
    public List<Data> rows;

    [System.Serializable]
    public struct Data
    {
        public string serverId;
        public string serverName;
    }
}