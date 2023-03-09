using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneRoot : MonoBehaviour
{
    [SerializeField] private WorldManager worldManager = null;

    private void Awake()
    {
        Debug.Assert(worldManager, "WorldManager is Null !!");
    }
}
