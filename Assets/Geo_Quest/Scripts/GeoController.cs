using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    string One = "Hello ";
    int var1 = 3;
    Rigidbody2D rb;
    public float speed = 25;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log("I am a Square");
        string Two = "World!";
        Debug.Log(One + Two);

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(var1++);
        //transform.position += new Vector3(0.005f, 0, 0);

        /*
        if (Input.GetKeyDown(KeyCode.W)) { transform.position += new Vector3(0, 1, 0); }
        if (Input.GetKeyDown(KeyCode.A)) { transform.position += new Vector3(-1, 0, 0); }
        if (Input.GetKeyDown(KeyCode.S)) { transform.position += new Vector3(0, -1, 0); }
        if (Input.GetKeyDown(KeyCode.D)) { transform.position += new Vector3(1, 0, 0); }
        */

        //rb.velocity = new Vector2(-1, rb.velocity.y);
       
        /*
        if (Input.GetKey(KeyCode.A)) { rb.velocity = new Vector2(-1, rb.velocity.y); }
        if (Input.GetKey(KeyCode.D)) { rb.velocity = new Vector2(1, rb.velocity.y); }
        */

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (xInput * speed, rb.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
    }
}
