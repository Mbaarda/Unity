using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {


	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        GetComponent<PlayerController>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void mainMenu(string Menu)
    {
        SceneManager.LoadScene(Menu);
    }

    public void restartGame(string Restart)
    {
        SceneManager.LoadScene(Restart);
        ScoreScript.scoreValue = 0;
    }

    public void exitGame(string Exit)
    {
        Application.Quit();
    }
}
