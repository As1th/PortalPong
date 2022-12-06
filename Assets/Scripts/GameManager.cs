using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public float LScore;
    public float RScore;
    public TextMeshProUGUI Rtext;
    public TextMeshProUGUI Ltext;
    public AIMover AI;
    public AudioSource goal;
    public AudioSource UI;
    public GameObject pauseMenu;
    public AudioSource beep;
    public float AIlimit;
    public GameObject winDialog;
    public bool gameWon;
    public TextMeshProUGUI wintext;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startCountdown());
    }
    IEnumerator startCountdown()
    {
        beep.pitch = 1;
        Rtext.text = "3";
        Ltext.text = "3";
        beep.Play();
        yield return new WaitForSeconds(1f);
        Rtext.text = "2";
        Ltext.text = "2";
        beep.Play();
        yield return new WaitForSeconds(1f);
        Rtext.text = "1";
        Ltext.text = "1";
        beep.Play();
        yield return new WaitForSeconds(1f);
        Rtext.text = "0";
        Ltext.text = "0";
        beep.pitch = 1.5f;
        beep.Play();
       
        spawnBallRight();
    }

    public void rightScore()

    {
        goal.Play();
        RScore++;
        Rtext.text = RScore.ToString();
        if (RScore >= 10)
        {
            win(2);
        }
        if (LScore - RScore >= 2)
        {
            AI.damp = AIlimit;

        }
        else if (RScore - LScore >= 2)

        {
            AI.damp = 0.38f;
        }

        else
        {
            AI.damp = 0.5f;
        }
    }

    public void leftScore()

    {
        goal.Play();
        LScore++;
        Ltext.text = LScore.ToString();
        if (LScore >= 10)
        {
            win(1);
        }
        if (LScore - RScore >= 2)
        {
            AI.damp = AIlimit;

        }
        else if (RScore - LScore >= 2)

        {
            AI.damp = 0.38f;
        }

        else
        {
            AI.damp = 0.5f;
        }
    }

    public void win(int i)
    {
        Time.timeScale = 0;
        gameWon = true;
        winDialog.SetActive(true);
        wintext.text = "Player " + i + " victory";
    }
 

    public void spawnBallRight()
    {
        ball.SetActive(true);
        float r = Random.Range(28,-31);
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.transform.position = new Vector3(0,1.8f, r);
        ball.GetComponent<Rigidbody>().AddForce(transform.right * 2000);

    }

    public void spawnBallLeft()
    {
        float r = Random.Range(27, -30);
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.transform.position = new Vector3(0, 1.8f, r);
        ball.GetComponent<Rigidbody>().AddForce(-transform.right * 2000);

    }

    public void pause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        UI.Play();
    }

    public void togglePause()
    {
        if (!gameWon)
        {

            if (Time.timeScale == 0)
            {
                unPause();
            }
            else
            {

                pause();
            }
        }
    }
    public void restart()
    {
        UI.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void exitToMenu()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            
           
              
            
        
    }
    public void unPause()
    {

        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        UI.Play();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            togglePause();
        
        }
    }
}
