using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalCameraPlayer : NetworkBehaviour
{
    // Use this for initialization
    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<drive>().enabled = true;
            GetComponent<WASDQE>().enabled = true;
            GetComponentInChildren<Camera>().enabled = true;
            controllerScript[] controllers = GetComponentsInChildren<controllerScript>();
            foreach (controllerScript obj in controllers)
            {
                obj.gameObject.SetActive(true);
            }
        }
    }
}