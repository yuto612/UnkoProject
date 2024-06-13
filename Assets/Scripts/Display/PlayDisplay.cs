using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unkoProject;

public class PlayDisplay : MonoBehaviour,IDisplay
{
    [SerializeField] private BallController ballController = null;

    public void GameStart()
    {
        ballController.CreateBall();
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
