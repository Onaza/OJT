using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStatusPresenter : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text bulletCountText = null;

    public void OnBulletCountChanged(int currentBulletCount)
    {
        bulletCountText.text = $"{currentBulletCount} / 10";
    }
}
