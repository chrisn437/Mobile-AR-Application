using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerButtons : MonoBehaviour
{

    public GameObject answerCbackBlue; // Blue is waiting
    public GameObject answerCbackGreen; //Green is correnct
    public GameObject answerCbackRed; // Red is wrong

    public GameObject answerBbackBlue; // Blue is waiting
    public GameObject answerBbackGreen; //Green is correnct
    public GameObject answerBbackRed; // Red is wrong


    public GameObject answerAbackBlue; // Blue is waiting
    public GameObject answerAbackGreen; //Green is correnct
    public GameObject answerAbackRed; // Red is wrong


    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;

    public AudioSource correctFX;
    public AudioSource incorrectFX;

    


    

    public void AnswerC()
    {
        if (QuestionDisplay.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            correctFX.Play();
            Score.scoreValue += 1;
        

        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            incorrectFX.Play();
            
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
    }

    public void AnswerB()
    {
        if (QuestionDisplay.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            correctFX.Play();
            Score.scoreValue += 1;
           
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
            incorrectFX.Play();
            
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
    }

    public void AnswerA()
    {
        if (QuestionDisplay.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            correctFX.Play();
            Score.scoreValue += 1;
            
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            incorrectFX.Play();
            
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
    }
}
