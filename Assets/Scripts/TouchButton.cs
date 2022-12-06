using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler

{
    public bool buttonPressed;
    public TouchButton oppositeButton;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
        oppositeButton.buttonPressed = false;
    }
   
    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
        
    }
}

