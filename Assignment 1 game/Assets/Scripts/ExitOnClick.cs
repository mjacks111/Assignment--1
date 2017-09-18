using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOnClick : MonoBehaviour {

    public void doQuit()
    {
        Debug.Log("has quit");
        Application.Quit();
    }
}
