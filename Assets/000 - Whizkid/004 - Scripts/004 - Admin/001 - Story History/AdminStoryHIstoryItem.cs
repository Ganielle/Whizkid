using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdminStoryHIstoryItem : MonoBehaviour
{
    [SerializeField] private StateController stateController;
    [SerializeField] private StoryAdminUserDataController storyAdminDataController;
    [SerializeField] private TextMeshProUGUI dateTMP;
    [SerializeField] private TextMeshProUGUI titleTMP;
    [SerializeField] private TextMeshProUGUI fullNameTMP;
    [SerializeField] private TextMeshProUGUI scoreTMP;
    [SerializeField] private Button viewBtn;

    [Header("DEBUGGER")]
    [SerializeField] private string historyID;

    public void HistoryData(string id, string date, string title, string fullname, float score)
    {
        dateTMP.text = date;
        titleTMP.text = title;
        fullNameTMP.text = fullname;
        scoreTMP.text = $"{score:n0}%";
        historyID = id;

        if (historyID == "")
            viewBtn.interactable = false;
        else
            viewBtn.interactable = true;
    }

    public void ViewBtn()
    {
        storyAdminDataController.selectedStoryID = historyID;
        storyAdminDataController.fullname = fullNameTMP.text;
        stateController.CurrentAppState = StateController.AppStates.ADMINSTORYDATA;
    }
}
