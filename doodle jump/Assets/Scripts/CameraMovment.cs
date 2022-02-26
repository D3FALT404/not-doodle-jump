using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovment : MonoBehaviour
{
    [SerializeField] private float cameraSpeed;
    [SerializeField] private Score score;
    private float lastPlatformYLocation = 0;

    public IEnumerator MoveTowards(float howFar)
    {
        float distance = howFar - lastPlatformYLocation;
        score.AddToScore(distance);
        lastPlatformYLocation = howFar;
        Vector3 target = new Vector3(0, gameObject.transform.position.y + distance, -10);
        while(target != gameObject.transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, cameraSpeed);
            yield return null;
        }
    }
}