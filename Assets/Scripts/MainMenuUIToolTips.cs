using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuUIToolTips : MonoBehaviour
{
    public TextMeshProUGUI tooltipText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void defaultText()
    {
        tooltipText.text = "PICK A GAMEMODE!";
    }

    public void PaddlePortalsText()
    {
        tooltipText.text = "THE PADDLES ARE DIRECT PORTALS TO THE CENTER! FOCUS ON THE MIDDLE!";
    }
    public void PortalFrenzyText()
    {
        tooltipText.text = "THE CLASSIC PONG YOU LOVE, BUT WITH PORTALS EVERYHWERE!";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
