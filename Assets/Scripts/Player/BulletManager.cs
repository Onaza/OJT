using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab = null;

    private Vector2 bound = Vector2.zero;

    public Vector2 Bound
    {
        set { bound = value; }
    }

    public void Fire()
    {
        Bullet bullet = Instantiate<Bullet>(bulletPrefab, transform.position, transform.rotation);
        bullet.Fire(bound);
    }
}
