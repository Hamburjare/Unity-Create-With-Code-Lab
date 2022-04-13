using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private SpawnManager spawnManager;
    private float topBound = 7;
    private float leftBound = -13;

    private void Start()
    {
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //jos objecti menee ruudun yläreunasta ulos se tuhoutuu
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //jos objecti menee vasemmasta reunasta ulos se tuhoutuu ja peli on ohitse
        else if (transform.position.x < leftBound)
        {
            spawnManager.GameOver();
            Destroy(gameObject);
        }
    }
}
