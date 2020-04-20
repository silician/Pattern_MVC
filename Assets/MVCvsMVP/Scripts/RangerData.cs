using MVCvsMVP.Scripts;
using UnityEngine;

[CreateAssetMenu]
public class RangerData : ScriptableObject //Мы написали класс RangerData и несколько свойств нашего рейнджера
{
    public string rangerName;
    public string rangerProf;
    public int rangerAge;
    public ERangerColor color;
    public Sprite rangerAva;
}


