using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string One = "Hello ";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log("I am a Square");

        string Two = "World!";
        Debug.Log(One + Two);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
