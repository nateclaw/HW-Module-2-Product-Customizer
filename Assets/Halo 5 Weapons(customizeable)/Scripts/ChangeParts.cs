using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using Unity.Mathematics;

public class ChangeParts : MonoBehaviour
{
    [SerializeField]
    private GameObject[] weapon1Attach;     //AR
    [SerializeField]
    private GameObject[] weapon2Attach;     //PDW
    [SerializeField]
    private GameObject[] weapon3Attach;     //BR
    [SerializeField]
    private GameObject[] weapon4Attach;     //DMR
    [SerializeField]
    private GameObject[] weapon5Attach;     //SMG
    [SerializeField]
    private GameObject[] weapon6Attach;     //FRAG

    Renderer tmp;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < weapon1Attach.Length; i++)    //Disables Weapon 1 attachments renderer 
        {
            tmp = weapon1Attach[i].GetComponent<Renderer>();
            tmp.forceRenderingOff = true;
        }
        for (int i = 0; i < weapon2Attach.Length; i++)  //Disables Weapon 2 attachments renderer
        {
            tmp = weapon2Attach[i].GetComponent<Renderer>();
            tmp.forceRenderingOff = true;
        }
        for(int i = 0;i < weapon3Attach.Length; i++)    //Disables Weapon 3 attachments renderer
        {
            tmp = weapon3Attach[i].GetComponent<Renderer>();
            tmp.forceRenderingOff = true;
        }
        for (int i = 0; i < weapon4Attach.Length; i++)  //Disables Weapon 4 attachments renderer
        {
            tmp = weapon4Attach[i].GetComponent<Renderer>();
            tmp.forceRenderingOff = true;
        }
        for (int i = 0; i < weapon5Attach.Length; i++)  //Disables Weapon 5 attachments renderer
        {
            tmp = weapon5Attach[i].GetComponent<Renderer>();
            tmp.forceRenderingOff = true;
        }
        for (int i = 0; i < weapon6Attach.Length; i++)  //Disables Weapon 6 attachments renderer to off
        {
            tmp = weapon6Attach[i].GetComponent<Renderer>();
            tmp.forceRenderingOff = true;
        }
    }

    public void toggleParts(int i)
    {

    }
}
