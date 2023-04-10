using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float initialGameSpeed = 5f;
    public float gameSpeed {get; private set; }
    public float gameSpeedIncrease = 0.05f;
    private Player player;
    private Spawner spawner;
    [SerializeField]
    private GameObject gameOver;
    [SerializeField]
    private GameObject scoreCanvas;
    [SerializeField]
    private GameObject scoreCanvas1;
    [SerializeField]
    public Text scoreText;
    private float score;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else DestroyImmediate(gameObject);
    }

    private void OnDestroy()
    {
        if(Instance == this)
            Instance = null;
    }

    private void Start()
    {

        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();
        NewGame();
        
    }

    private void NewGame()
    {
        Obstacle[] obstacles = FindObjectsOfType<Obstacle>();
        foreach(var obstacle in obstacles)
        {
            Destroy(obstacle.gameObject);
        }

        gameSpeed = initialGameSpeed;
        enabled = true;

        player.gameObject.SetActive(true);
        spawner.gameObject.SetActive(true);
        gameOver.SetActive(false);
        scoreCanvas.SetActive(true);
        scoreCanvas1.SetActive(true);
    }

    public void GameOver()
    {
        gameSpeed = 0f;
        enabled = false;
        player.gameObject.SetActive(false);
        spawner.gameObject.SetActive(false);
        gameOver.SetActive(true);
        scoreCanvas.SetActive(true);
        scoreCanvas1.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.deltaTime;
        score += gameSpeed * Time.deltaTime;
        scoreText.text = Mathf.RoundToInt(score).ToString();
        
    }
}
