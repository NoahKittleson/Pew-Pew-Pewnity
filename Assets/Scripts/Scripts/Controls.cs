using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
    public Rigidbody2D rb;
    public float movespeed;
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update () {  
        rb.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);

        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(new Vector2(3,0), ForceMode2D.Impulse);
        }      
        

        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.AddForce(new Vector2(0,2), ForceMode2D.Impulse);   
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            rb.AddForce(new Vector2(0,-2), ForceMode2D.Impulse);
        }
    }
}
