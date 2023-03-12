using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
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
        Bullet bullet = bulletPool.Get<Bullet>();
        if(!bullet)
            return;
        bullet.Destroyed = bulletPool.Restore;
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;
        bullet.Fire(bound);
    }
}
