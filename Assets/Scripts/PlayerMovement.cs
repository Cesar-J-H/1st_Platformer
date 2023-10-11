using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    public GameObject winTextObject;
    //public GameObject goal;

    public bool gotCoin = false;

    // Start is called before the first frame update
    void Start()
    {
        //get and store player rigidbody
        rb = GetComponent <Rigidbody2D>();
        winTextObject.SetActive(false);
        //goal.SetActive(false;)
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        if(Input.GetKey(KeyCode.Space)){
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Coin")){
            other.gameObject.SetActive(false);
            gotCoin = true;
        }

        if(other.CompareTag("Flag") && gotCoin == true){
            winTextObject.SetActive(true);
        }
    }
}
