using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceExpressionsController : MonoBehaviour
{
    private OVRFaceExpressions faceExpressions;
    private SkinnedMeshRenderer meshRenderer;

    // スタート時に呼ばれる
    void Start()
    {
        faceExpressions = GetComponent<OVRFaceExpressions>();
        meshRenderer = GetComponent<SkinnedMeshRenderer>();
    }

    // フレーム更新毎に呼ばれる
    void Update()
    {
        Debug.Log(faceExpressions[OVRFaceExpressions.FaceExpression.EyesClosedR]);

        if (faceExpressions == null || meshRenderer == null) return;

        // フェイストラッキングの有効時
        if (faceExpressions.FaceTrackingEnabled && faceExpressions.ValidExpressions)
        {
            // 目を閉じるを同期
            meshRenderer.SetBlendShapeWeight(13, 100 * faceExpressions[OVRFaceExpressions.FaceExpression.EyesClosedL]);
            meshRenderer.SetBlendShapeWeight(14, 100 * faceExpressions[OVRFaceExpressions.FaceExpression.EyesClosedR]);

            // 口の同期
            meshRenderer.SetBlendShapeWeight(29, 100 * faceExpressions[OVRFaceExpressions.FaceExpression.MouthLeft]);
        }
    }
}