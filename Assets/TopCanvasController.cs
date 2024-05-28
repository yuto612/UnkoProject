using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TopCanvasController : MonoBehaviour
{
    public Button StartButton;
    public Button ExitButton;

    public void OnClickEvent(PlayCanvasController canvas) 
    {
        StartButton.onClick.AddListener(() =>
        {
            canvas.gameObject.SetActive(true);
        });
    }

    void Start()
    {
      
    }

    void Update()
    {
        
    }
}
