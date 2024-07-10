using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR.LegacyInputHelpers;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 cameraOffset = new Vector3(0, 0, -5);

    // �Ǐ]�I�u�W�F�N�g�����邩
    private bool isFollowObject = false;
    private GameObject _camera = null;
    private GameObject _followObject = null;

    /// <summary>
    /// �I�u�W�F�N�g���J�����ɒǏ]���܂�
    /// </summary>
    public void Follow(GameObject followObject)
    {
        // �J�����擾
        _camera = Camera.main.gameObject;
        _followObject = followObject;
        isFollowObject = true;
    }

    public void Update()
    {
        if (isFollowObject)
        {
            // �{�[���̈ʒu���J�����̈ʒu�ɑ������
            _camera.transform.position = _followObject.transform.position + cameraOffset;
            // TODO:�{�[���Ƃ̃��O��t����
            // TODO:�㏸����ƁA����ȉ��ɉ�����Ȃ�����
        }
    }
}
