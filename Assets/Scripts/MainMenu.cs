using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool TwoPlayerMode;
    public Image OnePlayerButton;
    public Image TwoPlayerButton;
    // Start is called before the first frame update
    void Start()
    {
        TwoPlayerMode = false;
    }

    public void setTwoPlayer()
    {
        if (TwoPlayerMode)
        {

        }
        else
        {
            TwoPlayerMode = true;
            OnePlayerButton.color = Color.white;
            TwoPlayerButton.color =  new Color(255 / 100, 251 / 100, 54 / 100);
        }
    
    }
    public void setOnePlayer()
    {
        if (TwoPlayerMode)
        {
            TwoPlayerMode = false;
            TwoPlayerButton.color = Color.white;
            OnePlayerButton.color = new Color(44 / 100, 255 / 100, 255 / 100);
        }
        else
        {
           
        }

    }

    public void startPPMode()
    {
        if (TwoPlayerMode)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("2PlayerPaddle", LoadSceneMode.Single);
        }
        else {
            Time.timeScale = 1;
            SceneManager.LoadScene("1PlayerPaddle", LoadSceneMode.Single);
        }
    }

    public void startPFMode()
    {
        if (TwoPlayerMode)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("2PlayerFrenzy", LoadSceneMode.Single);
        }
        else
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("1PlayerFrenzy", LoadSceneMode.Single);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
