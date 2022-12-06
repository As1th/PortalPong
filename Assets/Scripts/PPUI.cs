using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PPUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool mouse_over = false;
    public MainMenuUIToolTips tips;
    void Update()
    {
        if (mouse_over)
        {
            Debug.Log("Mouse Over");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        tips.PaddlePortalsText();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        tips.defaultText();
    }
}