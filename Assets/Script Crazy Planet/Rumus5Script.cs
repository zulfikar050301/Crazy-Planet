using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rumus5Script : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    public void rumus2()
    {
        SceneManager.LoadScene("Rumus2");
    }

    public void rumus1()
    {
        SceneManager.LoadScene("Rumus");
    }

    public void rumus4()
    {
        SceneManager.LoadScene("Rumus4");
    }

    public void rumus3()
    {
        SceneManager.LoadScene("Rumus3");
    }
}
