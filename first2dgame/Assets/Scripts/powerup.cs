using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    [SerializeField]
    private float speed;

   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,1,0) * speed * Time.deltaTime);

        
    }

    private void OnTriggerEnter2D(Collider2D other)
        {
            
            if(other.tag == "Player")
            {
                  //accessing player script
               player1 playerv = other.GetComponent<player1>();

               if(playerv != null)
               {
                //enable triple shot
               playerv.tripleshotpowerupon();
               }
                //destroy powerup
                Destroy(this.gameObject);
            }
               
            
        }
}
