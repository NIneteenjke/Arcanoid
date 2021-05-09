using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public float speed;
    public GameObject Left;
    public GameObject Right;
    public GameObject board;
    public int score;
    public float horizontalSpeed = 20.0f;
  
   

    void Update()
    {   
            float h = horizontalSpeed * Input.GetAxis("Mouse X");

            board.transform.position= transform.position + new Vector3 (h * Time.deltaTime , 0 , 0);
 
            if (transform.position.x > Left.transform.position.x)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }   
    
            if (transform.position.x < Right.transform.position.x)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
    }
}
