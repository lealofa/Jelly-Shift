using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AgarName : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    void Start()
    {
             playerNameText.text = MenuController.playerName;
    }

    
}
