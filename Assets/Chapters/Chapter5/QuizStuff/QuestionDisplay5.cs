using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay5 : MonoBehaviour
{
    public GameObject screenQuestion;

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;

    public static string actualAnswer;


    void Start()
    {
        screenQuestion.GetComponent<Text>().text = "If the Rule of Thirds was followed, the image looks ...";

        answerA.GetComponent<Text>().text = "Cheerful";
        answerB.GetComponent<Text>().text = "Harmonious";
        answerC.GetComponent<Text>().text = "Chaotic";
        actualAnswer = "B";


    }

    // Update is called once per frame
    void Update()
    {

    }
}
