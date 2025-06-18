using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float speed = 5f;
    public float leftBound;
    
    private void Start()
    {
        // Set the left bound to the left edge of the screen
        // Adjust the left bound to be slightly off-screen
        leftBound = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 1f;
    }


    public void Update()
    {
        // Move the pipe to the left
        transform.position += Vector3.left * speed * Time.deltaTime;
        // Check if the pipe has moved off-screen and destroy it
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
