using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager1 : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyShip;
    [SerializeField]
    private GameObject[] Powerups;
    private GameManager _gamemanager ;
   
    // Start is called before the first frame update
    void Start()
    {
       _gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 public void StartSpawn()
 {
     StartCoroutine(EnemySpawnRoutine()); 
        StartCoroutine(PowerupSpawnRoutine());  
 }

    //enemy spwan
    IEnumerator EnemySpawnRoutine()
    {
        
      
        while(_gamemanager.gameOver == false)
        {
            Instantiate(EnemyShip, new Vector3( Random.Range(-7.4f,7.4f), 5.77f, 0), Quaternion.identity);
            yield return new WaitForSeconds(3.0f);
        }
    }

    //powerups spawn
    IEnumerator PowerupSpawnRoutine()
    {
        
      
        while(_gamemanager.gameOver == false)
        {
            int randomp = Random.Range(0,2);
            Instantiate(Powerups[randomp], new Vector3( Random.Range(-7.4f,7.4f), 5.77f, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
}
