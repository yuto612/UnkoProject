using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDisplay : MonoBehaviour,IDisplay
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
