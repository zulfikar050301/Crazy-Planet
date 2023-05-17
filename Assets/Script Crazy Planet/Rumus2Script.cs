using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rumus2Script : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    public void rumus1()
    {
        SceneManager.LoadScene("Rumus");
    }

    public void rumus3()
    {
        SceneManager.LoadScene("Rumus3");
    }

    public void rumus4()
    {
        SceneManager.LoadScene("Rumus4");
    }

    public void rumus5()
    {
        SceneManager.LoadScene("Rumus5");
    }

}
