using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private SpawnManager spawnManager;
    public int pointValue;
    public GameObject explosionFx;
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        spawnManager.UpdateScore(pointValue);
        Destroy(other.gameObject);
        Explode();
    }


        void Explode()
        {
            GameObject clone = (GameObject)Instantiate(explosionFx, transform.position, explosionFx.transform.rotation);
            Destroy(clone, 1.0f);
        }
}
