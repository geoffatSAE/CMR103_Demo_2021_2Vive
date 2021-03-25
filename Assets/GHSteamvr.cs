using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR; //add Valve's SteamVR system.

public class GHSteamvr : MonoBehaviour
{
    public GHColorChange cube;
    
    // Update is called once per frame
    void Update()
    {

        // check steam vr for a input action, in this case InteractUI which is the trigger
        if (SteamVR_Actions._default.InteractUI.GetStateDown(SteamVR_Input_Sources.Any))
        {
            cube.SetGreen();

        } else
        {
            cube.SetRed();
        }


    }
}
