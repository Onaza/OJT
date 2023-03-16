using UnityEngine;
using UnityEngine.UI;

public class ServerListItem : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text serverName = null;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener( ()=>
        {
            SceneLoader.Instance.Add<ServerListItem>(this.gameObject);
            SceneLoader.Instance.LoadAsyncScene("Main", Process);
        });
    }

    private void Process()
    {
        Debug.Log("플레이어 생성");
        Debug.Log("적 군 생성");
    }

    public void Set(ServerListResponse.Data data)
    {
        serverName.text = data.serverId;
        gameObject.SetActive(true);
    }
}