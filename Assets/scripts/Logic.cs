using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public BirdScript birdScript;
    public int score;
    public Text ScoreText;
    public GameObject gameoverscreen;
    public int hScore;
    public Text hScoreText;
    public AudioSource ClickSFX;
    public bool PipeIncreaseSpeed = false;

    [ContextMenu("Increase Score")]
    public void AddScore(int ScoretoAdd)
    {
        score += ScoretoAdd;
        ScoreText.text = score.ToString();
        playSFX();
    }
    public void playSFX()
    {
        if (score == 0)
        {
            birdScript.SFX.mute = true;
        }
        if (score >= 1)
        {
            birdScript.SFX.mute = false;
            birdScript.SFX.Play();
        }
    }
    public void restartgame()
    {
        ClickSFX.mute = false;
        StartCoroutine(waiter());
        IEnumerator waiter()
        {
            ClickSFX.Play();
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void gameOver()
    {
        gameoverscreen.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            restartgame();
        }
    }
    public void menuscene()
    {
        ClickSFX.mute = false;
        StartCoroutine(waiter());
        IEnumerator waiter()
        {
            ClickSFX.Play();
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("Main menu");
        }

      
    }
    public void hScoreAdd()
    {
        if(hScore < score)
        {
            hScore = score;
            PlayerPrefs.SetInt("HighScore", hScore);
        }
    }
    public void setScore()
    {
        hScore = PlayerPrefs.GetInt("HighScore", 0);
        hScoreText.text = hScore.ToString();
    }
    private void Start()
    {
        hScore = PlayerPrefs.GetInt("HighScore", 0);
        hScoreText.text = hScore.ToString();
        birdScript = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
        birdScript.SFX.mute = true;
        ClickSFX.mute = true;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameoverscreen.activeSelf == true)
        {
            restartgame();
        }
    }
}
