using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour 
{

    private enum GameState
    {
        Paused,
        Play
    }
    private GameState gameState;

	// Use this for initialization
	void Start () 
    {
        gameState = GameState.Play;
	}

	// Update is called once per frame
	void Update () 
    {
	    if(Input.GetKeyDown(KeyCode.Escape) && gameState == GameState.Play)
        {
            gameState = GameState.Paused;
            Time.timeScale = 0;            
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && gameState == GameState.Paused)
        {
            gameState = GameState.Play;
            Time.timeScale = 1;
        }

	}
}
