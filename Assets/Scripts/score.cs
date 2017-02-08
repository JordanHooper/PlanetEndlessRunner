using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text myText, healthText;
    float speed = 10f, currentScore = 0f;
    int health, modifier = 10;
    Rigidbody ship;
    //AudioSource audio

    void Start()
    {
        ship = GetComponent<Rigidbody>();
        health = 3;
    }

    void Update()
    {
        if (health > 0)
        {
            speed += 0.1f;
            currentScore += (Time.deltaTime * modifier);
            ship.AddForce(transform.forward * speed);
        }
        myText.text = "Current score: " + currentScore.ToString("f0");
        healthText.text = "Health: " + health;
    }

    void OnColliderEnter(Collider col)
    {
        if (col.tag == "obstacle")
        {
            health--;
            Destroy(col);
            //instantiate an explosion
            //audio.Play(explsion);
        }
    }

}
