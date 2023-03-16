using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ServerListItem : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text serverName = null;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener( ()=>
        {
            
        });
    }

    public void Set(ServerListResponse.Data data)
    {
        this.serverName.text = data.serverId;
        gameObject.SetActive(true);
    }
}