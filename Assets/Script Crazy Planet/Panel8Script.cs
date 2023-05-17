using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Panel8Script : MonoBehaviour
{
    
    public void Page7()
    {
        SceneManager.LoadScene("Panel7");
    }

    public void Page9()
    {
        SceneManager.LoadScene("Panel9");
    }

    public void exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
