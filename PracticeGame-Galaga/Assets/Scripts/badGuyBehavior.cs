using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badGuyBehavior : MonoBehaviour
{
    public int speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
    }
}
