using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Policy_OrientMind : MonoBehaviour
{
    //[FormerlySerializedAs("onPolicyAccepted")]
    public UnityEvent onPolicyAccepted_OrientMind;

    //[FormerlySerializedAs("onPolicyNotAccepted")]
    public UnityEvent onPolicyNotAccepted_OrientMind;

    public void CheckIfPolicyAccepted()
    {
        if (PlayerPrefs.HasKey("Policy"))
        {
            if (PlayerPrefs.GetInt("Policy") == 1)
            {
                onPolicyAccepted_OrientMind?.Invoke();
            }
            else
            {
                onPolicyNotAccepted_OrientMind?.Invoke();
            }
        }
        else
        {

            onPolicyNotAccepted_OrientMind?.Invoke();
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    }



    public void OnClickAccept()
    {
        PlayerPrefs.SetInt("Policy", 1);


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }


}
