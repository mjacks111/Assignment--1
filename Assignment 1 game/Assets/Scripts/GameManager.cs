using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float RestartValue = 2f;

    public GameObject completeLevelUI;

    public void Completelevel()
    {
        Debug.Log("LEVEL WON!");
        completeLevelUI.SetActive(true);
        Invoke("MenuCall", 1f);
        
       
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", RestartValue);
        }

    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void MenuCall ()
    {
        SceneManager.LoadScene(0);
    }
}
