using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBillboard : MonoBehaviour
{
    [SerializeField] private Transform tartget = null;

    private void Awake()
    {
        Debug.Assert(tartget, "Target is Null !!");
    }

    private void Start()
    {
        StartCoroutine(Billboard());
    }

    private IEnumerator Billboard()
    {
        WaitForFixedUpdate waitForFixedUpdate = new WaitForFixedUpdate();

        while(true)
        {
            transform.LookAt(tartget);
            yield return waitForFixedUpdate;
        }
    }
}
