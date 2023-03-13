using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    int score = 0;

    int lives = 3;

    bool gameOver = false;

    public Text scoreText;

    public GameObject liveHolder;

    public GameObject gameOverPanel;



    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void liveCounter()
    {
        if (lives > 0)
        {
            lives--;
            liveHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }

        if(lives <= 0)
        {
            gameOver = true;

            GameOver();
        }

    }

    public void getScore ()
    {
        if (!gameOver) {
            score++;
            scoreText.text = score.ToString();
            print(score);
        }
    }

    public void GameOver()
    {
        CandySpawn.instance.StopSpawner();
        GameObject.Find("Player").gameObject.GetComponent<PlayerController>().canMove = false;
        gameOverPanel.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
