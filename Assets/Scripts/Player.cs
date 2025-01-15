using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
    Rigidbody2D rb;
    void Start()
{
   rb = GetComponent<Rigidbody2D>();
}

void Update()
{
    if(Input.GetMouseButton(0))
    {
        Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
 if(touchPos.x < 0){
        rb.AddForce(Vector2.left * speed);
 }else{
        rb.AddForce(Vector2.right * speed);
 }
        
    }else{
        rb.linearVelocity = Vector2.zero;
    }
}



void OnCollisionEnter2D(Collision2D col)
{
    if(col.gameObject.tag == "Block")
    {
        SceneManager.LoadScene(0);
    }
}


}
