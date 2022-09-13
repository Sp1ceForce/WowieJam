using UnityEngine;
using DG.Tweening;
public class LogoShake : MonoBehaviour
{
    [SerializeField] int maxAmplitude;
    [SerializeField] float shakeTime;
    RectTransform rectTransform;
    void Start()
    {
        rectTransform=GetComponent<RectTransform>();
        rectTransform.DOAnchorPosY(rectTransform.anchoredPosition.y - maxAmplitude, shakeTime).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
