using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel6Script : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    public void Page1()
    {
        SceneManager.LoadScene("Content");
    }

    public void Page2()
    {
        SceneManager.LoadScene("Panel2");
    }

    public void Page3()
    {
        SceneManager.LoadScene("Panel3");
    }

    public void Page4()
    {
        SceneManager.LoadScene("Panel4");
    }

    public void Page5()
    {
        SceneManager.LoadScene("Panel5");
    }

    public void Page7()
    {
        SceneManager.LoadScene("Panel7");
    }
}
