using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{ 
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}
