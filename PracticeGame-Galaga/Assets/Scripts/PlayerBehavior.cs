using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    //variables for movement
    private Rigidbody2D playerBody;
    private float xMovement;
    public float speed;

    //variables for shooting
    public GameObject laser;
    public float fireRate;
    private float fireRateCounter;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        updateTimers();
        xMovement = Input.GetAxis("Horizontal");
        
        
    }
    private void FixedUpdate()
    {
        playerBody.velocity = new Vector2(xMovement * speed, 0);
        if (Input.GetKey(KeyCode.Space) )
        {
            fireLaser();
        }
    }
    private void fireLaser()
    {
        if (fireRateCounter < 0)
        {
            Instantiate(laser, playerBody.position, Quaternion.identity);
            fireRateCounter = fireRate;
        }
    }
    private void updateTimers()
    {
        fireRateCounter -= Time.deltaTime;
    }
    private void fixPos()
    {
        if (gameObject.transform.position.x > 10)
        {
            gameObject.transform.position = new Vector2(10,0);
        }

        if (gameObject.transform.position.x < -10)
        {
            gameObject.transform.position = new Vector2(-10, 0);
        }
    }
}
