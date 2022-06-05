using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorExplode : DetectCollision
{
    public static MeteorExplode Instance;

    public GameObject explosionFx;
    
    public int damage;

    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    void OnTriggerEnter(Collider other)
    {
        Explode();
    }


    void Explode()
    {
        GameObject clone = (GameObject)Instantiate(explosionFx, transform.position, explosionFx.transform.rotation);
        Destroy(clone, 1.0f);
    }
}
