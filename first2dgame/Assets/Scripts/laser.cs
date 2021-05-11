using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    [SerializeField]
    private float speed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
       Movement(); 
    }

    void Movement()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if(transform.position.y > 5.76f)
        {
            Destroy(this.gameObject);
        }
    }


 

}
