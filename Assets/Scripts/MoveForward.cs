using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    public float meteorSpeed = 10.0f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (UIManager.Instance.isGameActive)
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
