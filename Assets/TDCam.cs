using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDCam : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(90, 0, 0);
    }
}
