using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    [SerializeField]
    private float speed;
    public GameObject laser_prefab;
    private float canfire = 0.0f;
    [SerializeField]
    private float firerate = 0.25f;
    public bool canTripleShot = false;
    public bool canSpeedup = false;
    
    void Start()
    {
        transform.position = new Vector3(0,-3,0);
    }

    
    void Update()
    {
        Movement();
        Shooting();
        speedft();
        
    }

    void Movement()
    {
        //user input
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        
        //movement
        transform.Translate(new Vector3(horiz,vert,0) * speed * Time.deltaTime);

        //yaxis boundary
        if(transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x , 0, 0);
        }

        if(transform.position.y < -3.71f)
        {
            transform.position = new Vector3(transform.position.x , -3.71f, 0);
        }

        //xaxis boundary
        if(transform.position.x < -9.891702f)
        {
            transform.position = new Vector3(9.587938f ,transform.position.y , 0);
        }
        
        if(transform.position.x > 9.863181f)
        {
            transform.position = new Vector3(-9.55f ,transform.position.y , 0);
        }
    }


    void Shooting()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
           //cooldown system for shooting
           if(Time.time > canfire)
           {
               
                if(canTripleShot == true)
                {
                      Instantiate(laser_prefab, transform.position + new Vector3(-0.3f,1.9f,0), Quaternion.identity);
                      Instantiate(laser_prefab, transform.position + new Vector3(0.3f,1.9f,0), Quaternion.identity);
                      Instantiate(laser_prefab, transform.position + new Vector3(0,1.53f,0), Quaternion.identity);
                      canfire = Time.time + firerate;
                      
                }
                else
                {
                    Instantiate(laser_prefab, transform.position + new Vector3(0,1.53f,0), Quaternion.identity);
                    canfire = Time.time + firerate;
                }
               
           }
           
        }

    }



    //tripleshot cool down
public void tripleshotpowerupon()
{
    canTripleShot = true;
    StartCoroutine(powerdowntriple());
}
          public IEnumerator powerdowntriple()
          {
              yield return new WaitForSeconds(5.0f);
              canTripleShot = false;
          }



          //speedup enable
          private void speedft()
          {
              if( canSpeedup == true)
              {
                  speed = 10.0f;
              }
              else
              {
                  speed = 5.0f;
              }
          }

// speedup cooldown
          public void speeduppowerupon()
          {
            canSpeedup = true;
            StartCoroutine(powerdownspeedup());
          }


          public IEnumerator powerdownspeedup()
          {
              yield return new WaitForSeconds(5.0f);
              canSpeedup = false;
          }
        
        
    
}
