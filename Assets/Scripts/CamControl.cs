using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public Transform cibleCam;

    void Update()
    {
        this.transform.LookAt(cibleCam);
    }
}
