using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    [SerializeField] private int platfomsCount;
    private float distanceLastPlatform = 0;

    // Start is called before the first frame update
    private void Start()
    {
        spawnPlatforms();
    }

    private void spawnPlatforms()
    {
        for(int i = 0; i < platfomsCount; i++)
        {
            float randomX = Random.Range(-6f, 6f);
            float randomY = Random.Range(1, 3.5f);
            distanceLastPlatform += randomY;
            Instantiate(platform, new Vector3(randomX, distanceLastPlatform), Quaternion.identity);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}