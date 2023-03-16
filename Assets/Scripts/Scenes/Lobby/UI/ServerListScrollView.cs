using UnityEngine;

public class ServerListScrollView : MonoBehaviour
{
    [SerializeField] private Transform content = null;
    [SerializeField] private ServerListItem itemPrefab = null;

    private void Awake()
    {
        string url = "https://api.neople.co.kr/df/servers?apikey=Zf9caeZ7X1l6sS6YwPUNjJ0nYfdtjudF";
        Request.GET(url, ServerListResponse);
    }

    private void ServerListResponse(string json)
    {
        ServerListResponse response = JsonUtility.FromJson<ServerListResponse>(json);

        for (int i = 0; i < response.rows.Count; i++)
            Instantiate<ServerListItem>(itemPrefab, content).Set(response.rows[i]);
    }
}
