using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    [SerializeField] private float cameraSpeed;
    private float lastPlatformYLocation = 0;

    public IEnumerator MoveTowards(float howFar)
    {
        float distance = howFar - lastPlatformYLocation;
        lastPlatformYLocation = howFar;
        Vector3 target = new Vector3(0, gameObject.transform.position.y + distance, -10);
        while(target != gameObject.transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, cameraSpeed);
            yield return null;
        }
    }
}