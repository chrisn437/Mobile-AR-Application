using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavToLoc1 : MonoBehaviour
{
    

    public void location1()
    {
        if (NavScript.cityOrnature == 1)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=Amaliehaven+Copenhagen");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=Amaliehaven+Copenhagen");
            }
        }

        if (NavScript.cityOrnature == 2)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=55.682185+12.566980");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=55.682185+12.566980");
            }
        }
    }

    public void location2()
    {
        if (NavScript.cityOrnature == 1)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=Schloss+Amalienborg");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=Schloss+Amalienborg");
            }
        }

        if (NavScript.cityOrnature == 2)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=55.680467+12.566685");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=55.680467+12.566685");
            }
        }
    }

    public void location3()
    {
        if (NavScript.cityOrnature == 1)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=Marmorkirken+St.+(Metro),+Copenhagen");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=Marmorkirken+St.+(Metro),+Copenhagen");
            }
        }

        if (NavScript.cityOrnature == 2)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=55.679700+12.565423");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=55.679700+12.565423");
            }
        }
    }

    public void location4()
    {
        if (NavScript.cityOrnature == 1)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=Frederiks+Kirke");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=Frederiks+Kirke");
            }
        }

        if (NavScript.cityOrnature == 2)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=55.683214+12.580509");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=55.683214+12.580509");
            }
        }
    }

    public void location5()
    {
        if (NavScript.cityOrnature == 1)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=55.683399+12.595530");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=55.683399+12.595530");
            }
        }

        if (NavScript.cityOrnature == 2)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=55.684288+12.580324");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=55.684288+12.580324");
            }
        }
    }

    public void location6()
    {
        if (NavScript.cityOrnature == 1)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=Amaliehaven+Copenhagen");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=Amaliehaven+Copenhagen");
            }
        }

        if (NavScript.cityOrnature == 2)
        {
            try
            {
                Application.OpenURL("http://maps.apple.com/?saddr=Current+Location&daddr=55.685026+12.578690");
            }
            catch
            {
                Application.OpenURL("http://maps.google.com/?saddr=My+Location&daddr=55.685026+12.578690");
            }
        }
    }
}
