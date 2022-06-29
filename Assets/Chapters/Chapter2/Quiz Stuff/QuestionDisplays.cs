using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestionDisplays : MonoBehaviour
{

    public GameObject screenQuestion;

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;

    public static string actualAnswer;


    void Start()
    {
        screenQuestion.GetComponent<Text>().text = "What is often called a standard focal length?";

        answerA.GetComponent<Text>().text = "50 mm";
        answerB.GetComponent<Text>().text = "80 mm";
        answerC.GetComponent<Text>().text = "100 mm";
        actualAnswer = "A";


    }

    // Update is called once per frame
    void Update()
    {

    }
}
