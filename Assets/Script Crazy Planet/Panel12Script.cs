using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Panel12Script : MonoBehaviour
{

    public void Page11()
    {
        SceneManager.LoadScene("Panel11");
    }

    public void Page13()
    {
        SceneManager.LoadScene("Panel13");
    }

    public void exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
