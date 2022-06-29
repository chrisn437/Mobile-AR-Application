using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestionDisplay : MonoBehaviour
{

    public GameObject screenQuestion;

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;

    public static string actualAnswer;


    void Start()
    {
        screenQuestion.GetComponent<Text>().text = "What setting did you just " +
            "learn about?";

        answerA.GetComponent<Text>().text = "Color Space";
        answerB.GetComponent<Text>().text = "HDR";
        answerC.GetComponent<Text>().text = "Aperture";
        actualAnswer = "C";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
