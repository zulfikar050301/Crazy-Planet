using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProfilScript : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
