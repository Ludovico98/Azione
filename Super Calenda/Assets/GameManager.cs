using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;

    public GameObject WinUI;
    public GameObject BtnOff;

    public void Win()
    {
        WinUI.SetActive(true);
        BtnOff.SetActive(false);
        Debug.Log("Win");

    }

    public void EndGame()
    {
        //Player dies
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", 2f);
        }
        // Load menu, restart game / exit game
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
