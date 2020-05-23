using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Transform tf;   //Holds the trasnform component

    Vector3 myVector = new Vector3(0, 0, 0); // Vector3 for starting position

    public float speed = 0.01f; // variable for designers to manipulate in engine

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();  //Get the Transform component
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.right * speed); //Automaticlly moves sprite across the screen to the right at a speed determined by designer
    }
}
