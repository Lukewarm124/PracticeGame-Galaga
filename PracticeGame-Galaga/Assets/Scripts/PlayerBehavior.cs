using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    //variables for movement
    private Rigidbody2D playerBody;
    private float xMovement;
    public float speed;
    private float maxPos = 11;

    //variables for shooting
    public GameObject laser;
    public float fireRate;
    private float fireRateCounter;
    public GameObject laserOrigin;
    

    //variables for health and getting hit


    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        xMovement = Input.GetAxis("Horizontal");
        
        
    }
    private void FixedUpdate()
    {
        updateTimers();
        playerBody.velocity = new Vector2(xMovement * speed, 0);
        if (Input.GetKey(KeyCode.Space) )
        {
            fireLaser();
        }
        fixPos();
    }
    private void fireLaser()
    {
        if (fireRateCounter < 0)
        {
            Instantiate(laser, laserOrigin.transform.position, Quaternion.identity);
            fireRateCounter = fireRate;
        }
    }
    private void updateTimers()
    {
        fireRateCounter -= Time.deltaTime;
    }
    private void fixPos()
    {
        if (gameObject.transform.position.x > maxPos)
        {
            gameObject.transform.position = new Vector2(maxPos,playerBody.transform.position.y);
        }

        if (gameObject.transform.position.x < -maxPos)
        {
            gameObject.transform.position = new Vector2(-maxPos,playerBody.transform.position.y);
        }
    }
}
