using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player_prefab;
    public bool gameOver = true;
    private UIManager _uimanager2;

    private void Start()
    {
        _uimanager2 = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    void Update()
    {
        if(gameOver == true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(player_prefab, new Vector3(0,-3,0), Quaternion.identity);
                _uimanager2.HideMenu();
                gameOver = false;
                
            }
           
        }
    }
}
