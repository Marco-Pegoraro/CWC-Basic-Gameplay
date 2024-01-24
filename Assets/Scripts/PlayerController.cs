using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public GameObject projectile;

    private float horizontalInput;

    private float speed = 10f;

    private float xRange = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }

        if(transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        } 
        else if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

    }
}
