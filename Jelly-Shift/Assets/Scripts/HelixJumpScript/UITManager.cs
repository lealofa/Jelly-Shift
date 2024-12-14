using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UITManager : MonoBehaviour
{
    
    
    public float revealDuration=1f;
    
    

        
   public void OnClickTween(RectTransform rectTransform)
    {
        rectTransform.DOScale(rectTransform.localScale * 1.25f, revealDuration / 6f).SetLoops(2, LoopType.Yoyo);
    }
}
