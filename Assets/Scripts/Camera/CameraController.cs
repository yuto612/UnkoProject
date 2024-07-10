using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR.LegacyInputHelpers;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 cameraOffset = new Vector3(0, 0, -5);

    // 追従オブジェクトがあるか
    private bool isFollowObject = false;
    private GameObject _camera = null;
    private GameObject _followObject = null;

    /// <summary>
    /// オブジェクトをカメラに追従します
    /// </summary>
    public void Follow(GameObject followObject)
    {
        // カメラ取得
        _camera = Camera.main.gameObject;
        _followObject = followObject;
        isFollowObject = true;
    }

    public void Update()
    {
        if (isFollowObject)
        {
            // ボールの位置をカメラの位置に代入する
            _camera.transform.position = _followObject.transform.position + cameraOffset;
            // TODO:ボールとのラグを付ける
            // TODO:上昇すると、それ以下に下がらない実装
        }
    }
}
