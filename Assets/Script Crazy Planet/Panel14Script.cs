using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Panel14Script : MonoBehaviour
{

    public void Page13()
    {
        SceneManager.LoadScene("Panel13");
    }

    public void Page15()
    {
        SceneManager.LoadScene("Panel15");
    }

    public void exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
