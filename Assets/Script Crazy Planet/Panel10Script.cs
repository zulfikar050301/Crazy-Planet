using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Panel10Script : MonoBehaviour
{

    public void Page9()
    {
        SceneManager.LoadScene("Panel9");
    }

    public void Page11()
    {
        SceneManager.LoadScene("Panel11");
    }

    public void exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
