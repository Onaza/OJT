using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneRoot : MonoBehaviour
{
    [SerializeField] private WorldManager worldManager = null;
    [SerializeField] private PlayerManager playerPrefab = null;

    private FollowCamera followCamera = null;

    private void Awake()
    {
        Debug.Assert(playerPrefab, "playerPrefab is Null !!");
        Debug.Assert(worldManager, "WorldManager is Null !!");

        if(!followCamera)
            followCamera = Camera.main.GetComponent<FollowCamera>();

        Instantiate<PlayerManager>(playerPrefab);

        Debug.Assert(followCamera, "FollowCamera is Null !!");
    }

    private void Start()
    {
        followCamera.StartFollow(PlayerManager.Instance.transform);

        worldManager.Initialize();
    }
}
