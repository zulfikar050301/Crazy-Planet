using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Panel15Script : MonoBehaviour
{

    public void Page14()
    {
        SceneManager.LoadScene("Panel14");
    }

    public void Page1()
    {
        SceneManager.LoadScene("Content");
    }

    public void exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
