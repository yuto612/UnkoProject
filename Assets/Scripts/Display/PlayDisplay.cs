using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unkoProject;

public class PlayDisplay : MonoBehaviour,IDisplay
{
    [SerializeField] private BallController ballController = null;
    [SerializeField] private CameraController cameraController = null;

    public void GameStart()
    {
        // �{�[���𐶐�
        var ball = ballController.CreateBall();
        // �{�[���ɃJ������Ǐ]
        // �J�����I�u�W�F�N�g�A�{�[���I�u�W�F�N�g
        cameraController.Follow(ball.gameObject);
    }

    #region IDisplay impl
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }
    #endregion
}
