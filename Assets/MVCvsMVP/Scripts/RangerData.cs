using MVCvsMVP.Scripts; 
using UnityEngine;

[CreateAssetMenu]
public class RangerData : ScriptableObject // 1) Мы написали класс кот будет содержать несколько опред свойств, и унаследовали его от скрптбл обжект(теперь мы можем создавать скриптбл обжект с этими свойствами , а с помощью CreateAssetMenu мы можем деалть это через правую кнопку мыши)
{
    public string rangerName;
    public string rangerProf;
    public int rangerAge;
    public ERangerColor color;
    public Sprite rangerAva;
}


