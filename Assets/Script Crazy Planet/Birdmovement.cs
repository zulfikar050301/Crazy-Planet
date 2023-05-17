using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Birdmovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public float jumpForce;
    float score;
    public GameObject GameOver;
    public Text scoreTxt;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        scoreTxt.text = "Score : " + score;

        if(Input.GetMouseButtonDown(0))
        {
            GameObject.Find ("suara sayap").GetComponent<AudioSource> ().Play();
            Rb.velocity = Vector2.up * jumpForce;
            
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="point")
        {
            score++;
            GameObject.Find ("suara score").GetComponent<AudioSource> ().Play();
        }
        if(collision.gameObject.tag =="pipa")
        {
            GameObject.Find ("suara hit").GetComponent<AudioSource> ().Play();
            Destroy(gameObject);
            GameOver.SetActive (true);
        }
        if(collision.gameObject.tag=="Land")
        {
            GameObject.Find ("suara ground").GetComponent<AudioSource> ().Play();
            Destroy(gameObject);
            GameOver.SetActive (true);
        }
    }
}
