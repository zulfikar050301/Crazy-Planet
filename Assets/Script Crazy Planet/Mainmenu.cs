using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{

   public void Play()
    {
        SceneManager.LoadScene("MainGame");
    }

   public void materi()
    {
        SceneManager.LoadScene("Content");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Kuiz()
    {
        SceneManager.LoadScene("KuizMenu");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Explanation1");
    }

    public void Profil()
    {
        SceneManager.LoadScene("Profil");
    }

    public void Rumus()
    {
        SceneManager.LoadScene("Rumus");
    }
}
