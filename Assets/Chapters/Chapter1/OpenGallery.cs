using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGallery : MonoBehaviour
{
    public GameObject Gallery;
    public GameObject GalleryNature;
    public GameObject Info;
    public GameObject InfoNature;
    public GameObject BackgroundInfo;
    public GameObject BackgroundGalery;

    public void OpenTheGallery()
    {
        
        if (NavScript.cityOrnature == 1)
        {
            if (Gallery != null)
            {
                bool isActive = Gallery.activeSelf;

                BackgroundGalery.SetActive(!isActive);
                Gallery.SetActive(!isActive);
            }
        }
        else if (NavScript.cityOrnature == 2)
        {
            if (GalleryNature != null)
            {
                bool isActive = GalleryNature.activeSelf;

                BackgroundGalery.SetActive(!isActive);
                GalleryNature.SetActive(!isActive);
            }
        }


    }

    public void OpenTheInfo()
    {
        
        if (NavScript.cityOrnature == 1)
        {
            if (Info != null)
            {
                
                bool isActive = Info.activeSelf;

                BackgroundInfo.SetActive(!isActive);
                Info.SetActive(!isActive);
            }
        }

        else if (NavScript.cityOrnature == 2)
        {
            if (InfoNature != null)
            {
                bool isActive = InfoNature.activeSelf;

                BackgroundInfo.SetActive(!isActive);
                InfoNature.SetActive(!isActive);
            }
        }

    }



}
