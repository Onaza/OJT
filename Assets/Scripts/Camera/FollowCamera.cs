using System.Collections;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform target = null;

    [SerializeField] private float distance = 10.0f;
    [SerializeField] private float height = 5.0f;
    [SerializeField] private float smoothRate = 5.0f;

    private void Awake()
    {
        Debug.Assert(target, "Target is Null !!");
    }

    private void Start()
    {
        StartCoroutine(Follow());
    }

    private IEnumerator Follow()
    {
        WaitForFixedUpdate waitForFixedUpdate = new WaitForFixedUpdate();

        float angle = 0f;
        Quaternion rotation = Quaternion.identity;

        while(true)
        {
            angle = Mathf.LerpAngle(transform.eulerAngles.y, target.eulerAngles.y, smoothRate * Time.deltaTime);
            // rotation = Quaternion.Euler(0f, angle, 0f);

            transform.position = target.position - (rotation * Vector3.forward * distance) + (Vector3.up * height);
            transform.LookAt(target);

            yield return waitForFixedUpdate;
        }
    } 
}
