using System;
using UnityEngine;
using UnityEngine.UI;

public class RangerView : MonoBehaviour // 4) тут мы создаем класс-представление для вьюшки списка рейнджеров,он отвечает за хранение данных, визуал, клики юзера и стэйт перед загрузкой данных.
{
    public Button button;
    public Image rangerIcon;

    private RangerData rangerData;

    public void InitRanger(RangerData ranger, Action<RangerData> callback) //метод для исходного стэйта ( для того чтобы передать этот метод мы используем события )
    {
        this.rangerData = ranger;
        rangerIcon.sprite = rangerData.rangerAva; //с помощью этого мы можем добавить иконку к представлению=)
        
        button.onClick.AddListener(() => callback(rangerData));
    }
}
