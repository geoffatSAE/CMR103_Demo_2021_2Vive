using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GHViveHands : MonoBehaviour
{

    public GHColorChange theCube; //reference to the cube we're going to change

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {  
        //This debug's the current state of the hands
        if (ViveHandTracking.GestureProvider.LeftHand != null)    
            Debug.Log("Left gesture is " + ViveHandTracking.GestureProvider.LeftHand.gesture);  
        if (ViveHandTracking.GestureProvider.RightHand != null)    
            Debug.Log("Right gesture is " + ViveHandTracking.GestureProvider.RightHand.gesture);


        //

        if(ViveHandTracking.GestureProvider.RightHand != null) //check we can currecntly see/track hand.
        {
            //Test for the current tracked gesture
            if(ViveHandTracking.GestureProvider.RightHand.gesture == ViveHandTracking.GestureType.Fist)
            {
                //Right hand is a Fist, do something
                theCube.SetGreen();
            } else if (ViveHandTracking.GestureProvider.RightHand.gesture == ViveHandTracking.GestureType.Five)
            {
                //Right hand is a Five, do something else
                theCube.SetRed();
            }
             

        }
       
    
    }

 }
    
