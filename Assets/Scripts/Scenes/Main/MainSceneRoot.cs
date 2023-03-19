using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneRoot : MonoBehaviour
{
    [SerializeField] private WorldManager worldManager = null;
    [SerializeField] private PlayerManager playerPrefab = null;

    private FollowCamera followCamera = null;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {
        Debug.Assert(playerPrefab, "playerPrefab is Null !!");
        Debug.Assert(worldManager, "WorldManager is Null !!");

        SceneManager.SetActiveScene(scene);

        if(!followCamera)
            followCamera = Camera.main.GetComponent<FollowCamera>();

        Instantiate<PlayerManager>(playerPrefab);

        Debug.Assert(followCamera, "FollowCamera is Null !!");

        followCamera.StartFollow(PlayerManager.Instance.transform);

        worldManager.Initialize();
    }
}
