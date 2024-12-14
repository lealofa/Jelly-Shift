using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestScript : MonoBehaviour
{
    public void Restart()
    {
        Invoke("LoadSceneAfterDelay", 0.2f); 
        
    }

    public void LoadSceneAfterDelay()
    {
        SceneManager.LoadScene("HelixScene");
    }

  

}
