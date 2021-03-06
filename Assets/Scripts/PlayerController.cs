using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed = 20;
    private float horizontalInput;
    public float xRange = 13;
    public GameObject projectilePrefab;


    // Update is called once per frame
    void Update()
    {
        if (UIManager.Instance.isGameActive)
        {
            // pelaaja liikkuu vasemmalle ja oikeelle k�ytt�en horizontal input
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

            // Pit�� pelaajan ruudulla
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }
            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                // laukasee ohjuksen pelaajasta
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }
            if (Input.GetKey("escape"))
            {
                //Application.Quit();
                UIManager.Instance.PauseMenu();
            }

        }

    }
}
