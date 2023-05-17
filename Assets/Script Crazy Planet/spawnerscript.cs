using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerscript : MonoBehaviour
{
    float time = 0;
    float timer = 1;
    public GameObject PIPE;
    

    void Update()
    {
        if (time<=0)
        {
            Instantiate(PIPE, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
