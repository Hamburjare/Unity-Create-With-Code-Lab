using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private SpawnManager spawnManager;
    public float speed = 40.0f;
    public float meteorSpeed = 10.0f;
    private void Start()
    {
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (spawnManager.isGameActive)
        {
            if (gameObject.CompareTag("Meteor"))
            {
                transform.Translate(Vector3.left * Time.deltaTime * meteorSpeed);
            }
            else
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
        }
        
    }
}
