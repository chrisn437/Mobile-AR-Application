using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavScript : MonoBehaviour
{
    public static int cityOrnature;
    public static int phoneOrCamera;

    public void TaskOnClick()
    {
        cityOrnature = 1;
        SceneManager.LoadScene("City");
    }

    public void TaskOnClick2()
    {
        cityOrnature = 2;
        SceneManager.LoadScene("Nature");
    }

    public void phoneorCamera1()
    {
        phoneOrCamera = 1;
        SceneManager.LoadScene("Aperture Phone");
    }

    public void phoneorCamera2()
    {
        phoneOrCamera = 2;
        SceneManager.LoadScene("Answer was camera");
    }

    public void AnswerWasCamera()
    {
        SceneManager.LoadScene("Answer was camera");
    }

    public void CityOrNature()
    {
        SceneManager.LoadScene("Decide");
    }

    public void SettingsQuiz()
    {
        SceneManager.LoadScene("Settings Quiz");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void LensesAndFocalLength()
    {
        SceneManager.LoadScene("Lenses & Focal Length");
    }

    public void Chapter1()
    {
        SceneManager.LoadScene("Chapter 1");
    }

    public void PhoneOrCamera()
    {
        SceneManager.LoadScene("Phone or Camera");
    }

    public void Aperature()
    {
        SceneManager.LoadScene("Aperture");
    }

    public void ISOCamera()
    {
        SceneManager.LoadScene("ISOCamera");
    }

    public void Shutter()
    {
        SceneManager.LoadScene("Shutter");
    }

    public void EndCamera()
    {
        SceneManager.LoadScene("EndCamera");
    }

    public void EndPhone()
    {
        SceneManager.LoadScene("EndPhone");
    }

    public void AperturePhone()
    {
        SceneManager.LoadScene("Aperture Phone");
    }

    public void Exposure()
    {
        SceneManager.LoadScene("Exposure");
    }

    public void ToEnd()
    {
        if (phoneOrCamera == 1)
        {
            SceneManager.LoadScene("EndPhone");
        }

        if (phoneOrCamera == 2)
        {
            SceneManager.LoadScene("EndCamera");
        }
    }

    public void Chapter1End()
    {
        SceneManager.LoadScene("Chapter1End");
    }

    public void StartUpPage()
    {
        SceneManager.LoadScene("StartUpPage");
    }
    

    public void Introduction()
    {
        SceneManager.LoadScene("Introduction");
    }

    public void Introduction2()
    {
        SceneManager.LoadScene("Introduction2");
    }

    public void Intro2()
    {
        SceneManager.LoadScene("Intro 2.0");
    }

    public void LensesQuiz()
    {
        SceneManager.LoadScene("LensesQuiz");
    }

    public void SettingsLenses()
    {
        SceneManager.LoadScene("SettingsLenses");
    }

    public void Perspectives()
    {
        SceneManager.LoadScene("Perspectives");
    }

    public void cameraOfPhone()
    {
        if (phoneOrCamera == 1)
        {
            SceneManager.LoadScene("IfPhone Lenses");
        }

        if (phoneOrCamera == 2)
        {
            SceneManager.LoadScene("IfCamera Lenses");
        }
    }

    public void PerspectivesQuiz()
    {
        SceneManager.LoadScene("PerspectivesQuiz");
    }

    public void SettingsPerspectives()
    {
        SceneManager.LoadScene("SettingsPerspective");
    }

    public void Composition()
    {
        SceneManager.LoadScene("Composition");
    }

    public void RuleOfThirds()
    {
        SceneManager.LoadScene("Rule Of Thirds");
    }

    

    public void LeadingLines()
    {
        SceneManager.LoadScene("LeadingLinesQuiz");
    }

    public void SettingsLeadingLines()
    {
        SceneManager.LoadScene("SettingsLeadingLines");
    }

    public void Composition2()
    {
        SceneManager.LoadScene("Composition 2");
    }

    public void PoCRuleOfThirds()
    {
        if (phoneOrCamera == 1)
        {
            SceneManager.LoadScene("Phone SettingsRuleOfThirds 1");
        }

        if (phoneOrCamera == 2)
        {
            SceneManager.LoadScene("Camera SettingsRuleOfThirds");
        }
    }

    public void LeadingLinesQuiz()
    {
        SceneManager.LoadScene("LeadingLinesQuiz");
    }

    public void RuleOfThirdsQuiz()
    {
        SceneManager.LoadScene("Rule of Thirds Quiz");
    }

    public void SettingsRuleOfThirds()
    {
        SceneManager.LoadScene("SettingsRuleOfThirds");
    }

    public void Foreground()
    {
        SceneManager.LoadScene("Foreground");
    }

    public void SettingsForeground()
    {
        SceneManager.LoadScene("SettingsForeground");
    }

    public void AnswerWasSkip()
    {
        SceneManager.LoadScene("Answer was skip");
    }

    public void AnswerWasContinue()
    {
        SceneManager.LoadScene("Answer was continue");
    }

    public void AnswerWasRepeat()
    {
        SceneManager.LoadScene("Answer was pls repeat");
    }

    

    public void Lighting1()
    {
        SceneManager.LoadScene("Lighting 1");
    }

    public void Lighting2()
    {
        SceneManager.LoadScene("Lighting 2");
    }

    public void Lighting3()
    {
        SceneManager.LoadScene("Lighting 3");
    }

    public void ForegroundQuiz()
    {
        SceneManager.LoadScene("Foreground Quiz");
    }

    public void LightingDecide()
    {
        SceneManager.LoadScene("LightingDecide");
    }

    public void Lighting()
    {
        SceneManager.LoadScene("Lighting");
    }

    public void EndPage()
    {
        SceneManager.LoadScene("End Page");
    }

    public void EndInteraction()
    {
        SceneManager.LoadScene("End Interactive");
    }

    public void AnswerYes()
    {
        SceneManager.LoadScene("AnswerWasYes");
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
