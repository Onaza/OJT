using System;
using System.Collections.Generic;
using UnityEngine;

public class LobbySceneUIRoot : MonoBehaviour
{
    [SerializeField] private ServerListScrollView serverListScrollView = null;

    private void Awake()
    {
        Debug.Assert(serverListScrollView, "serverListScrollView is null !!");
    }
}
