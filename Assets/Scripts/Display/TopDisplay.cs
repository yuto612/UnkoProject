using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopDisplay : MonoBehaviour,IDisplay
{
    public Button StartButton;
    public Button ExitButton;

    public event Action OnStartButtonEvent;

    //public void OnClickEvent(playDisplay canvas)
    public void OnClickEvent()
    {
        StartButton.onClick.AddListener(() =>
        {
            //canvas.gameObject.SetActive(true);
            OnStartButtonEvent.Invoke();
        });
    }

    void Start()
    {
        OnClickEvent();
    }

    void Update()
    {

    }

    #region IDisplay impl

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
    #endregion
}
