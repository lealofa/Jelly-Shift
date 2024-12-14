using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostJelly : MonoBehaviour
{
    public static GhostJelly Instance;
    public Transform[] ghostPos;

    private int index = 0;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        
    }

    public void ChangeScaleOfTheGhost (Vector3 scale)
    {
        scale.y *= 2f;
        transform.localScale = scale;
    }

    public void ChangePosOfTheGhost()
    {
        index++;
        if (ghostPos.Length>index)
        {
            transform.position = ghostPos[index].transform.position; 
        }
    }
}
