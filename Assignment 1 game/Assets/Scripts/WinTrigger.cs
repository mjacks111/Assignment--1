using UnityEngine;

public class WinTrigger : MonoBehaviour {



    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.Completelevel();
    }
}
