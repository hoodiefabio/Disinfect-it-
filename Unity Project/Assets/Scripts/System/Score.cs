using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score = 0;
    public Text UIText;
    public GameObject pauseMenu;
    private GameOver gameOver;

    private void Start()
    {
        gameOver = GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver._gameOver == false && pauseMenu.activeInHierarchy == false)
        {
            UIText.text = ("Score:" + score);
        }
    }
}
