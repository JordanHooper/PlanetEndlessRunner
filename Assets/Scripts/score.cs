using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text myText;
    float timing = 0f;
    int modifier = 10;

    void Update()
    {
        currentScore += (Time.deltaTime * modifier);

        myText.text = "Current score: " + timing("f2");
    }

}
