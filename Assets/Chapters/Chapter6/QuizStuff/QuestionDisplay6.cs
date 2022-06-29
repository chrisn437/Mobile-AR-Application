using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay6 : MonoBehaviour
{
    public GameObject screenQuestion;

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;

    public static string actualAnswer;


    void Start()
    {
        screenQuestion.GetComponent<Text>().text = "What do you achieve with the Foreground technique?";

        answerA.GetComponent<Text>().text = "Shallowness";
        answerB.GetComponent<Text>().text = "Depth";
        answerC.GetComponent<Text>().text = "2D-Effect";
        actualAnswer = "B";


    }

    // Update is called once per frame
    void Update()
    {

    }
}
