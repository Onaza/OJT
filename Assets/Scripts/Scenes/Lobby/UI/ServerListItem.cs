using System;
using UnityEngine;
using UnityEngine.UI;

public class ServerListItem : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text serverName = null;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener( ()=>
        {
            PlayerManager.Instance.Data.SetServerName(serverName.text);
        });
    }

    public void SetServerName(string serverName)
    {
        this.serverName.text = serverName;
    }
}