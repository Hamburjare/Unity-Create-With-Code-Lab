using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public int pointValue;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameManager.Instance.UpdateScore(pointValue);
        Destroy(other.gameObject);
    }

}
