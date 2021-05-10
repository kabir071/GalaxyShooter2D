using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,1,0)* speed * Time.deltaTime);

        public void OnTriggerEnter2D(Collider2D other)
        {
            if(other.tag="Player")
            {
                Destroy(this.gameObject);
            }
        }
    }
}
