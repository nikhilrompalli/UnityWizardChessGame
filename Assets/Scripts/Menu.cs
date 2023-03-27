using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Menu : MonoBehaviour
{
    public Button easyButton;
    public Button hardButton;
    public Button aiVsAiButton;
    public Button quitButton;

    //public Text title;

    public void AiVsAi()
    {
        Board.gameType = 2;
        SceneManager.LoadScene( "Chess" );
    }

    public void StartEasy()
    {
        Board.gameType = 1;
        SceneManager.LoadScene( "Chess" );
    }

    public void StartHard()
    {
        Board.gameType = 0;
        SceneManager.LoadScene( "Chess" );
    }

    public void Quit()
    {
        Application.Quit();
    }

    public TextMeshProUGUI title;

    void Start()
    {
        //easyButton.enabled = false;
        //title = GetComponentInChildren<TMPro.TextMeshPro>();
        //Debug.Log(title.gameObject.tag);
        title.gameObject.SetActive(false);
        easyButton.gameObject.SetActive(false);
        hardButton.gameObject.SetActive(false);
        aiVsAiButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
        //title.enabled = false;

    }


    // Update is called once per frame
    void Update()
    {
        StartCoroutine(addButtons());
    }

    IEnumerator addButtons()
    {
        yield return new WaitForSeconds(10f);
        title.gameObject.SetActive(true);
        easyButton.gameObject.SetActive(true);
        hardButton.gameObject.SetActive(true);
        aiVsAiButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }
}
