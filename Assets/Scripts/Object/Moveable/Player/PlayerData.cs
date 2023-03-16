using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PlayerData
{
    private string serverName;
    private string id;
    private string hp;

    public void SetServerName(string serverName)
    {
        this.serverName = serverName;
    }
}
