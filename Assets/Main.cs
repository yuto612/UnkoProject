using System.Linq;
using UnityEngine;

public class Main : MonoBehaviour
{
    public TopDisplay topDisplay;
    public PlayDisplay playDisplay;

    void Start()
    {
        //topDisplay.OnClickEvent(playDisplay);

        // �g�b�v�f�B�X�v���C��\��
        ShowDisplay(topDisplay);

        // �C�x���g�o�^
        topDisplay.OnStartButtonEvent += (() =>
        {
             ShowDisplay(playDisplay);
        });
    }

    private void HideDisplayAll(IDisplay[] displays)
    {
        displays.ToList().ForEach(display => display.Hide());
    }

    private void ShowDisplay(IDisplay display)
    {
        this.HideDisplayAll(GetDisplayArray());
        display.Show();
    }

    private IDisplay[] GetDisplayArray()
    {
        IDisplay[] displays = new IDisplay[]
        {
            topDisplay,
            playDisplay
        };
        return displays;
    }
}
