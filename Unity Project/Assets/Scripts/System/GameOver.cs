using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private Collider2D[] enemies;
    public GameObject gameOverScreen;
    public bool _gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        _gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        enemies = Physics2D.OverlapBoxAll(new Vector2(0, 0), new Vector2(20, 40), 0);

        if(enemies.Length > 10)
        {
            Gameover();
        }
    }

    private void Gameover()
    {
        gameOverScreen.SetActive(true);
        _gameOver = true;
    }
}
