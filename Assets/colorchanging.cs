using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
//using UnityEngine.XR.PXR;

public class colorchanging : MonoBehaviour

{
    public GameObject sphere;
    //private InputDevices device;
    private bool leftTriggerState = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(change());
    }

    IEnumerator change()
    {
        yield return new WaitForSecondsRealtime(3);

        InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.triggerButton, out leftTriggerState);
        if (leftTriggerState)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
        }

        else
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.color = new Color(41, 191, 9, 1);

        }
    }
}

//InputDevices.GetDeviceAtXRNode(XRNode.RightHAnd).TryGetFeatureValue(CommonUsages.triggerButton)