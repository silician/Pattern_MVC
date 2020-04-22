using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangerViewController : MonoBehaviour // 5) тут мы создаем контроллер 
{
    public Storage storageHolder; // контроллер содержить ссылку на хранилище , которое хранит наши рэйнджерДаты, которые мы создали в папке проекта(те скриптбл обжекты в папке ресурсы)
    public Transform storageViewParent; // ссылку на RangerStoragePanel чтобы создавать представления (наши вьюшки рейнджеров)  как дочерние объекты этой панельки
    public Transform rangerInfoPanelParent; //ссылку на RangerInfoPanel чтобы создавать представления (нашу инфо вьюшку)  как дочерние объекты этой панельки

    private GameObject infoViewPrefab; //сылку на префаб с самим представлением (вьюшкой) инфо панели
    private GameObject rangerViewPrefab; //сылку на префаб с самим представлением (вьюшкой) панели хранилищя
    
    private GameObject rangerInfoView; 

    private void Start() // в этом методе мы создаем экземпляр вьюшки-хранилища и вызываем метод InitRanger (строка 25) для того чтоб заполнить данные представления (сторэдж-вьшки) данными из модели (нашей RangerData) для каждого элемента (рейнджера) нашего хранилища и при клике на один из них будет вызван метод  CreateRangerInfoView и отобразится ифно бокс)))
    {
        rangerViewPrefab = (GameObject) Resources.Load("Ranger"); //показываем откуда загружать наш префаб в строке 13
        infoViewPrefab = (GameObject) Resources.Load("RangerInfoView"); //показываем откуда загружать наш префаб в строке 12

        foreach (var data in storageHolder.storage)
        {
            var dataGO = GameObject.Instantiate(rangerViewPrefab, storageViewParent);
            dataGO.GetComponent<RangerView>().InitRanger(data, CreateRangerInfoView);
        }
    }

    private void CreateRangerInfoView(RangerData data) //создаем метод для создания экземпляров представления (инфо бокс фьюшки). 
    {
        if (rangerInfoView != null)
        {
            Destroy(rangerInfoView);
        }
        
        rangerInfoView = GameObject.Instantiate(infoViewPrefab, rangerInfoPanelParent); //Мы сделали переменную rangerInfoView и проверяем ее перед созданием новой вьюшки rangerInfoView в сцене для того чтоб контроллер знал создавали ли мы ее раньше или нет.
        rangerInfoView.GetComponent<RangerInfoView>().Init(data);
    }
}
