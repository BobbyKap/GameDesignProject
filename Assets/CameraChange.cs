using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject FPCam;
    public GameObject TDCam;
    public int CamMode = 0;

    void Update()
    {
        if (Input.GetButtonDown("Switch"))
        {
            if (CamMode == 1)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            }
            StartCoroutine(CamChange());
        }
    }

    IEnumerator CamChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            FPCam.SetActive(false);
            TDCam.SetActive(true);
        }
        if (CamMode == 1)
        {
            TDCam.SetActive(false);
            FPCam.SetActive(true);
        }
    }
}
