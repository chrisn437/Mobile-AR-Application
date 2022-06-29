using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCam : MonoBehaviour
{
    public void openTheCam()
    {
        Application.OpenURL("http://camera/");
    
    }
}
