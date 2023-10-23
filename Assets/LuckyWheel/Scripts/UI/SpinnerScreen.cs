using System;
using ABCBoard.Scripts.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class SpinnerScreen : BaseScreenWithModel<IDModel>
{
    private int _spinnerID;

    // [SerializeField] private Image _name;
    [SerializeField] private Button _buttonPlay;

    void Start()
    {
        _buttonPlay?.onClick.AddListener(OnClickButton);
    }

    public void Back()
    {
        GameManager.CloseHome?.Invoke(true);
    }
    
    private void OnClickButton()
    {
        AudioManager.Instance.ClickSound();
        //  AudioManager.Instance.PlaySong(_bookID);
        Spinner.Instance.Rotate();
    }

    public override void BindData(IDModel model)
    {
        _spinnerID = model.songID;
        SetImage();
    }

    private void SetImage()

    {
        Spinner.Instance.ChangeMat(_spinnerID);
        OnClickButton();
    }

    public override ScreenType GetID() => ScreenType.Spinner;
}

public class IDModel
{
    public int songID;
}