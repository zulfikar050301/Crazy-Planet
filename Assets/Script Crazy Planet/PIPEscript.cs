using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIPEscript : MonoBehaviour
{
    float nilaiRandom;
    void Start()
    {
        nilaiRandom = Random.Range(6.88f, 2.48f);
        transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100, Time.deltaTime * 5);
    }
}
