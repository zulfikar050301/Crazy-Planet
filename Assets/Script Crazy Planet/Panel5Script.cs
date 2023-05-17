using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel5Script : MonoBehaviour
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

    public void Page6()
    {
        SceneManager.LoadScene("Panel6");
    }

    public void Page7()
    {
        SceneManager.LoadScene("Panel7");
    }
}
