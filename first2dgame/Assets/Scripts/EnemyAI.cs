using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
  public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        //reappear after y bound
        if(transform.position.y < -6.5)
        {
            float randomx = Random.Range(-7.4f,7.4f);
            transform.position = new Vector3(randomx, 6.5f, 0);
        }

    }
}
