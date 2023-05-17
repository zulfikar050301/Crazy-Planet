using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Panel9Script : MonoBehaviour
{

    public void Page8()
    {
        SceneManager.LoadScene("Panel8");
    }

    public void Page10()
    {
        SceneManager.LoadScene("Panel10");
    }

    public void exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
