using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Panel11Script : MonoBehaviour
{

    public void Page10()
    {
        SceneManager.LoadScene("Panel10");
    }

    public void Page12()
    {
        SceneManager.LoadScene("Panel12");
    }

    public void exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
