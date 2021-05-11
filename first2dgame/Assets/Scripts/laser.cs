using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    [SerializeField]
    private float speed;
    public GameObject enemyExplosion_prefab;
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


 //collision between enemy and laser
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        
        {
            Destroy(this.gameObject);
            Instantiate(enemyExplosion_prefab, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);

        }
    }

}
