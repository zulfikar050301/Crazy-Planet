using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Panel13Script : MonoBehaviour
{

    public void Page12()
    {
        SceneManager.LoadScene("Panel12");
    }

    public void Page14()
    {
        SceneManager.LoadScene("Panel14");
    }

    public void exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
