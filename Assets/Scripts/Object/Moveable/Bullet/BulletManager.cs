using System;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public Action<int> OnBulletCountChanged = null;
    
    [SerializeField] private Bullet bulletPrefab = null;

    private Vector2 bound = Vector2.zero;

    private ObjectPool bulletPool = null;

    private void Awake()
    {
        bulletPool = new ObjectPool(bulletPrefab);
    }

    public Vector2 Bound
    {
        set { bound = value; }
    }

    public void Fire()
    {
        // ObjectPool 적용 이전 코드
        // Bullet bullet = Instantinate<Bullet>(bulletPrefab);
        // bullet.Fire(bound); 

        Bullet bullet = bulletPool.Get<Bullet>();
        if(!bullet)
            return;

        OnBulletCountChanged?.Invoke(bulletPool.Count);
        bullet.Destroyed = bulletPool.Restore;
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;
        bullet.Fire(bound);
    }
}
