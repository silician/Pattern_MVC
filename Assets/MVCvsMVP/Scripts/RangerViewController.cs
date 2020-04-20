using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangerViewController : MonoBehaviour
{
    public Storage storageHolder;
    public Transform storageViewParent;
    public Transform rangerInfoPanelParent;

    private GameObject infoViewPrefab;
    private GameObject rangerViewPrefab;
    
    private GameObject rangerInfoView;

    private void Start()
    {
        rangerViewPrefab = (GameObject) Resources.Load("Ranger");
        infoViewPrefab = (GameObject) Resources.Load("RangerInfoView");

        foreach (var data in storageHolder.storage)
        {
            var dataGO = GameObject.Instantiate(rangerViewPrefab, storageViewParent);
            dataGO.GetComponent<RangerView>().InitRanger(data, CreateRangerInfoView);
        }
    }

    private void CreateRangerInfoView(RangerData data)
    {
        if (rangerInfoView != null)
        {
            Destroy(rangerInfoView);
        }
        
        rangerInfoView = GameObject.Instantiate(infoViewPrefab, rangerInfoPanelParent);
        rangerInfoView.GetComponent<RangerInfoView>().Init(data);
    }
}
