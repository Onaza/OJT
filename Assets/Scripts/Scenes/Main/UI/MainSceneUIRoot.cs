using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneUIRoot : MonoBehaviour
{
    [SerializeField] private BulletStatusPresenter bulletStatusPresenter = null;
    
    public void Binding(PlayerManager player)
    {
        PlayerManager.Instance.BulletManager.OnBulletCountChanged += bulletStatusPresenter.OnBulletCountChanged;
    }

    public void Unbinding(PlayerManager player)
    {
        PlayerManager.Instance.BulletManager.OnBulletCountChanged -= bulletStatusPresenter.OnBulletCountChanged;
    }
}
