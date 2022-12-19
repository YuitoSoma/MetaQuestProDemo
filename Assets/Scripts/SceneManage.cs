using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            SceneManager.LoadScene("EyeTracking");
        }

        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            SceneManager.LoadScene("FaceTracking");
        }

        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            SceneManager.LoadScene("BodyTracking");
        }

        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            SceneManager.LoadScene("Passthrough");
        }
    }
}
