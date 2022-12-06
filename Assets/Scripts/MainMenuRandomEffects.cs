using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuRandomEffects : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LCapsule;
    public MeshRenderer Lp;
    public GameObject RCapsule;
    public MeshRenderer Rp;
    public TextMeshProUGUI Ltext;
    public TextMeshProUGUI Rtext;
    public MeshRenderer Lmover;
    public MeshRenderer Rmover;
    void Start()
    {
        InvokeRepeating("StartRandomEffects", 0f, 5f);
        print("ssdd");
    }

    public void leftTextWhite()
    {
        Ltext.color = Color.white;
    }
    public void leftTextNormal()
    {
        Ltext.color = new Color(44/100,255/100,255/100);
    }
    public void rightTextWhite()
    {
        Rtext.color = Color.white;
    }
    public void rightTextNormal()
    {
        Rtext.color = new Color(255/100, 251/100, 54/100);
    }
    public void leftPaddleNormal()
    {
        Lmover.enabled = false ;
        LCapsule.SetActive(false);
        Lp.enabled = true;
        leftTextWhite();
    }
    public void leftPaddlePortal()
    {
        Lmover.enabled = true;
        LCapsule.SetActive(true);
        Lp.enabled = false;
        leftTextNormal();
    }
    public void rightPaddleNormal()
    {
        Rmover.enabled = false;
        RCapsule.SetActive(false);
        Rp.enabled = true;
        rightTextWhite();
    }
    public void rightPaddlePortal()
    {
        Rmover.enabled = true;
        RCapsule.SetActive(true);
        Rp.enabled = false;
        rightTextNormal();
    }
    public void StartRandomEffects()
    {
        StartCoroutine(RandomEffects());
    }
    public IEnumerator RandomEffects()
    {
        print("SD");
        yield return new WaitForSeconds(1f);
        leftPaddleNormal();
        rightPaddleNormal();
     

        yield return new WaitForSeconds(1f);
        leftPaddlePortal();
        rightPaddlePortal();
       
        yield return new WaitForSeconds(0.7f);
        leftPaddlePortal();
        rightPaddlePortal();
        yield return new WaitForSeconds(0.6f);
        leftPaddleNormal();
        yield return new WaitForSeconds(0.7f);
        rightPaddleNormal();
        yield return new WaitForSeconds(0.6f);
        leftPaddlePortal();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
