using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
  public float speed;
  public GameObject enemyExplosion_prefab;
  public int lives = 3;
  private UIManager _uimanager1;
  [SerializeField]
  private AudioClip _clip;
  private GameManager _gamemanager ;

  
  
    // Start is called before the first frame update
    void Start()
    {
       _gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
          if(_gamemanager.gameOver == false)
          {
               transform.position = new Vector3(Random.Range(-7.4f,7.4f), 6.5f, 0);
          }  
            
        }

    }
    

   



    //collision between enemy and laser and player
    private void OnTriggerEnter2D(Collider2D other)
    { 
        _uimanager1 = GameObject.Find("Canvas").GetComponent<UIManager>();
        if(other.tag == "Laser")
        
        {
            Destroy(other.gameObject);
            Instantiate(enemyExplosion_prefab, transform.position, Quaternion.identity);
            _uimanager1.UpdateScore();
            AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position);
            Destroy(this.gameObject);
            
        }

        else if(other.tag == "Player")
        {
            player1 player = other.GetComponent<player1>();
            if(player != null)
            {
                player.Damage();
            }
            Instantiate(enemyExplosion_prefab, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position);
            Destroy(this.gameObject);
            

        }
    }

}


