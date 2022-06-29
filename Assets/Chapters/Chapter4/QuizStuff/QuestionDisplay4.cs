using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay4 : MonoBehaviour
{
    public GameObject screenQuestion;

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;

    public static string actualAnswer;


    void Start()
    {
        screenQuestion.GetComponent<Text>().text = "Leading Lines is a technique related to ...";

        answerA.GetComponent<Text>().text = "Distance";
        answerB.GetComponent<Text>().text = "Composition";
        answerC.GetComponent<Text>().text = "Filtering";
        actualAnswer = "B";


    }

    // Update is called once per frame
    void Update()
    {

    }
}
