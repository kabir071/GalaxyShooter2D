using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private int powerupID;//0 for tripleshot, 1 for speed, 2 for shield
    [SerializeField]
    private AudioClip _clip;

   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,1,0) * speed * Time.deltaTime);
        if(transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D other)
        {
            
            if(other.tag == "Player")
            {
                AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position);
                  //accessing player script
               player1 playerv = other.GetComponent<player1>();

               if(playerv != null)
               {
                //enable triple shot
                if( powerupID == 0)
                {
                    playerv.tripleshotpowerupon();
                }
                //speed powerup
                else if( powerupID == 1)
                {
                    playerv.speeduppowerupon();
                }
                //shield powerup
                else if(powerupID == 2)
                {

                }
               
               }
                //destroy powerup
                Destroy(this.gameObject);
            }
               
            
        }
}
