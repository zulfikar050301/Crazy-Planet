using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Explanation1 : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    public void Page2()
    {
        SceneManager.LoadScene("Explanation2");
    }

    public void Page3()
    {
        SceneManager.LoadScene("Explanation3");
    }

    public void Page4()
    {
        SceneManager.LoadScene("Explanation4");
    }

    public void Page5()
    {
        SceneManager.LoadScene("Explanation5");
    }
}
