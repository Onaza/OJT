using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbySceneRoot : MonoBehaviour
{
    [SerializeField] private LobbySceneUIRoot uiRoot = null;

    private void Awake()
    {
        Debug.Assert(uiRoot, "UIRoot is Null !!");
    }
}
