using System.Collections;
using System.Collections.Generic;
using MVCvsMVP.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class RangerInfoView : MonoBehaviour // 6) Мы создаем представление инфо бокса,добовляем сслыки на части интерфейса (строки 9-13) и метод Инит
{
    public Image icon;
    public Text colorText;
    public Text nameText;
    public Text ageText;
    public Text profText;

    public void Init(RangerData data) //в этом методе мы настраиваем элементы нашего представления ( инфо бокса) согласно элементам модели (RangerData)
    {
        icon.sprite = data.rangerAva;
        nameText.text = "Имечко: " + data.rangerName;
        ageText.text = "Возраст: " + data.rangerAge;
        profText.text = "Профэшн: " + data.rangerProf;

        switch (data.color)
        {
            case ERangerColor.Green: colorText.text = "Цвет бойца: Зелень"; break;
            case ERangerColor.Red: colorText.text = "Цвет бойца: Краснюга"; break;
            case ERangerColor.Blue: colorText.text = "Цвет бойца: Голубенький"; break;
            case ERangerColor.Yellow: colorText.text = "Цвет бойца: Желтец"; break;
            case ERangerColor.Pink: colorText.text = "Цвет бойца: Розовушный"; break;
        }
    }
}


