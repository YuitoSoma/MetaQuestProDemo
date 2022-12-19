using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyController : MonoBehaviour
{
    GameObject[] points = new GameObject[70];
    OVRBody ovrBody;

    // �X�^�[�g���ɌĂ΂��
    void Start()
    {
        // �|�C���g�Q�̐���
        for (int i = 0; i < 70; i++)
        {
            points[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            if (i < 18)
            {
                points[i].transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            }
            else
            {
                points[i].transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            }
        }

        // �Q��
        ovrBody = GetComponent<OVRBody>();
    }

    // �t���[���X�V���ɌĂ΂��
    void Update()
    {
        // �{�f�B�g���b�L���O�̗L����
        if (ovrBody != null && ovrBody.BodyState != null)
        {
            OVRPlugin.BodyState bodyState = (OVRPlugin.BodyState)ovrBody.BodyState;

            // �|�C���g�Q�̍X�V
            for (int i = 0; i < 70; i++)
            {
                OVRPlugin.Posef pose = bodyState.JointLocations[i].Pose;
                Vector3 pos = this.points[i].transform.position;
                pos.x = pose.Position.x;
                pos.y = pose.Position.y;
                pos.z = pose.Position.z + 1;
                this.points[i].transform.position = pos;
            }
        }
    }
}