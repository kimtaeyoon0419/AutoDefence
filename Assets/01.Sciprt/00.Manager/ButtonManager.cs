// # System
using System;
using System.Collections;
using System.Collections.Generic;

// # Unity
using UnityEngine;

[Serializable]
public class Button
{
    public string btnName;
    public GameObject buttonObject;
    public GameObject blackColor;
}

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private List<Button> buttonList;

    

    public void SetButtonColor(string buttonName)
    {
        foreach (var button in buttonList)
        {
            if(button.btnName != buttonName)
            {
                button.blackColor.SetActive(true);
            }
            else
            {
                button.blackColor.SetActive(false);
            }
        }
    }
}
