using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    Animation anim;

    void Start()
    {
        Debug.Log("starting...");
        anim = GetComponent<Animation>();
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("on mouse enter");
        anim.Play();
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        anim.Play(PlayMode.StopAll);
        anim.Stop();
    }
    
}
