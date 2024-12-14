using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public static string playerName;
    
    public void StartGame()
    {
        if (!string.IsNullOrEmpty(usernameInput.text))
        {
            playerName = usernameInput.text;  
            SceneManager.LoadScene("AgarioScene"); 
        }
        else
        {
            Debug.Log("Lütfen bir kullanýcý adý girin!");
        }
    }

}
