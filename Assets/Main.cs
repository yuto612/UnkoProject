using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public TopCanvasController TopCanvasController;
    public PlayCanvasController PlayCanvasController;

    void Start()
    {
        TopCanvasController.OnClickEvent(PlayCanvasController);
    }

    void Update()
    {
        
    }
}
