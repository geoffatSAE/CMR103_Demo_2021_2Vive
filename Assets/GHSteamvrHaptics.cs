using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GHSteamvrHaptics : MonoBehaviour
{
    public SteamVR_Action_Vibration hapticAction;
    public SteamVR_Action_Boolean trackpadAction;


    // Update is called once per frame
    void Update()
    {
        if (trackpadAction.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            hapticAction.Execute(0, 1, 150, 75, SteamVR_Input_Sources.LeftHand);
            Debug.Log("haptic feedback from pressing trackpad");
        }
    }
}

//https://www.youtube.com/watch?v=lOaR-cUGzkc

