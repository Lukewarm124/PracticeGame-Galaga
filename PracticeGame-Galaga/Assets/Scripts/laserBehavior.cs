using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserBehavior : MonoBehaviour
{
    public int speed;
    private Rigidbody2D laserBody;
    void Start()
    {
        laserBody = GetComponent<Rigidbody2D>();
        laserBody.velocity = new Vector2(0,speed);
        Invoke("Die", 5);
    }
    private void Die()
    {
        Destroy(gameObject);
    }
    
}
