using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupscript : MonoBehaviour
{
    public int score;
    public AudioSource coinmusic;
    public Text scoreText;
    public Text winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "monetki")
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = "Score: " + score;
            coinmusic.Play();
        }
        if (collision.gameObject.tag == "danger")
        {
            Application.LoadLevel(Application.loadedLevel);
         
        }
        if (collision.gameObject.tag == "win")
        {
            winText.text = "You win, Score:"+ score;                                                        
        }

    }
}
