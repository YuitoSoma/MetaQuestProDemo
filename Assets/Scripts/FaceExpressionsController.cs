using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceExpressionsController : MonoBehaviour
{
    private OVRFaceExpressions faceExpressions;
    private SkinnedMeshRenderer meshRenderer;

    // �X�^�[�g���ɌĂ΂��
    void Start()
    {
        faceExpressions = GetComponent<OVRFaceExpressions>();
        meshRenderer = GetComponent<SkinnedMeshRenderer>();
    }

    // �t���[���X�V���ɌĂ΂��
    void Update()
    {
        Debug.Log(faceExpressions[OVRFaceExpressions.FaceExpression.EyesClosedR]);

        if (faceExpressions == null || meshRenderer == null) return;

        // �t�F�C�X�g���b�L���O�̗L����
        if (faceExpressions.FaceTrackingEnabled && faceExpressions.ValidExpressions)
        {
            // �ڂ����𓯊�
            meshRenderer.SetBlendShapeWeight(13, 100 * faceExpressions[OVRFaceExpressions.FaceExpression.EyesClosedL]);
            meshRenderer.SetBlendShapeWeight(14, 100 * faceExpressions[OVRFaceExpressions.FaceExpression.EyesClosedR]);

            // ���̓���
            meshRenderer.SetBlendShapeWeight(29, 100 * faceExpressions[OVRFaceExpressions.FaceExpression.MouthLeft]);
        }
    }
}