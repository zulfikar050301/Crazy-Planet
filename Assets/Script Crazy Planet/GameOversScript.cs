using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOversScript : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Return()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
