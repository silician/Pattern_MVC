using System;
using UnityEngine;
using UnityEngine.UI;

public class RangerView : MonoBehaviour
{
    public Button button;
    public Image rangerIcon;

    private RangerData rangerData;

    public void InitRanger(RangerData ranger, Action<RangerData> callback)
    {
        this.rangerData = ranger;
        rangerIcon.sprite = rangerData.rangerAva;
        
        button.onClick.AddListener(() => callback(rangerData));
    }
}
