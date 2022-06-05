using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 7;
    private float leftBound = -13;


    // Update is called once per frame
    void Update()
    {
        //jos objecti menee ruudun yl�reunasta ulos se tuhoutuu
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //jos objecti menee vasemmasta reunasta ulos se tuhoutuu ja peli on ohitse
        else if (transform.position.x < leftBound)
        {
            if (GameManager.Instance.health > 1)
            {
                GameManager.Instance.UpdateHealth(MeteorExplode.Instance.damage);
            }
            else
            {
                UIManager.Instance.GameOver();
            }
            Destroy(gameObject);
        }
    }
}
