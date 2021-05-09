using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBall : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    public static int score;
    public static int losse;
    public GameObject platform ;
    public GameObject lossePlatform ;
    public Text TextScore;
    public Text TextLosse;
    public float speed_ball;
    void Start()
    {   
        // if(Input.GetMouseButtonDown(0))
        // {
        rigidbody.transform.Translate(1,0,0);
        rigidbody.velocity= new Vector3(Random.Range(1f,10f)*Time.deltaTime*speed_ball, 0,Random.Range(1f,10f)*Time.deltaTime*speed_ball-3);
        
        // }
    }

     private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.name=="Board")
            {
                score++;
                TextScore.text=score.ToString();
                
            }
            if(collision.gameObject.name=="LossePlatform")
            {
                losse++;
                TextLosse.text=losse.ToString();
            }
         
        }
     void Update()
        {
        
        }
}
