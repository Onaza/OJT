using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager instance = null;

    public static PlayerManager Instance
    {
        get { return instance == null ? new PlayerManager() : instance; }
    }

    [SerializeField] private BulletManager bulletManager = null;
    [SerializeField] private Fire fireAction = null;

    private PlayerData data;

    private bool isInitiailzed = false;

    public void Initialize(Vector2 bound)
    {
        Debug.Assert(bulletManager, "BulletManager is Null !!");
        Debug.Assert(fireAction, "FireAction is Null !!");

        if(isInitiailzed)
            return;

        data = new PlayerData();
        
        bulletManager.Bound = bound;

        fireAction.Initialize(bulletManager);

        isInitiailzed = true;
    }
}
