using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    private readonly float WIDTH = 20f;
    private readonly float HEIGHT = 20f;

    [SerializeField] private Transform ground = null;

    private void Awake()
    {
        Debug.Assert(ground, "Ground is Null");

        ground.localScale = new Vector3(WIDTH, 1f, HEIGHT);
    }

    public void Initialize()
    {
        PlayerManager.Instance.Initialize( new Vector2(WIDTH, HEIGHT) );
    }
}
