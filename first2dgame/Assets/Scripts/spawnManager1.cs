using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager1 : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyShip;
    [SerializeField]
    private GameObject[] Powerups;
   
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(EnemySpawnRoutine()); 
        StartCoroutine(PowerupSpawnRoutine());  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    //enemy spwan
    IEnumerator EnemySpawnRoutine()
    {
        
      
        while(true)
        {
            Instantiate(EnemyShip, new Vector3( Random.Range(-7.4f,7.4f), 5.77f, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }

    //powerups spawn
    IEnumerator PowerupSpawnRoutine()
    {
        
      
        while(true)
        {
            int randomp = Random.Range(0,2);
            Instantiate(Powerups[randomp], new Vector3( Random.Range(-7.4f,7.4f), 5.77f, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
}
