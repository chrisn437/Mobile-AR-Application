using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject currentScore;
    public GameObject currentHeader;
    public static int scoreValue;

    

    void Update()
    {
        if (scoreValue >= 5)
        {
            currentHeader.GetComponent<Text>().text = "Excellent!";
            currentScore.GetComponent<Text>().text = "You answered 5 - 6 questions correctly. " +
                "You already seem to know a lot about photography theory. Keep going!";
        }

        if (scoreValue < 5 && scoreValue > 2)
        {
            currentHeader.GetComponent<Text>().text = "Good!";
            currentScore.GetComponent<Text>().text = "You answered 3 - 4 questions correctly, so you are on the right track. Keep it up and you'll become a real pro!";
        }

        if (scoreValue <= 2)
        {
            currentHeader.GetComponent<Text>().text = "Still Room!";
            currentScore.GetComponent<Text>().text = "You were able to answer 0 - 2 questions correctly. Don't get discouraged and repeat the theory and quiz at a later time!";
        }
    }
}
