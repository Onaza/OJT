using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerListItem : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text serverName = null;

    public void SetServerName(string serverName)
    {
        this.serverName.text = serverName;
    }
}
