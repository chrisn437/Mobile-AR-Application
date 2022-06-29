using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestionDisplay3 : MonoBehaviour
{

    public GameObject screenQuestion;

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;

    public static string actualAnswer;


    void Start()
    {
        screenQuestion.GetComponent<Text>().text = "According to theory, what perspective does not exist?";

        answerA.GetComponent<Text>().text = "Bird's eye view";
        answerB.GetComponent<Text>().text = "Normal perspective";
        answerC.GetComponent<Text>().text = "Hare perspective";
        actualAnswer = "C";


    }

    // Update is called once per frame
    void Update()
    {

    }
}
