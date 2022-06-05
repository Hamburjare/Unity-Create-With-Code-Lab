using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public int pointValue;
    public GameObject explosionFx;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        UIManager.Instance.UpdateScore(pointValue);
        Destroy(other.gameObject);
        Explode();
    }


        void Explode()
        {
            GameObject clone = (GameObject)Instantiate(explosionFx, transform.position, explosionFx.transform.rotation);
            Destroy(clone, 1.0f);
        }
}
