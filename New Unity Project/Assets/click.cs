using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class click : MonoBehaviour
{
    public bool susroom, flag, none, deadbody, crate, rope, bait;
    public GameObject susroomExterior;
    public GameObject susroomCam, boatCamMain, flagCam, deadBodyCam, ropeCam, crateCam, baitCam;
    private int switchCam;
    public TMP_Text sus1;
    public TMP_Text sus2;
    public TMP_Text sus3;
    void Start()
    {

    }

    void Update()
    {
        CheckBool();

    }
    public void CheckBool()
    {
        if (deadbody)
        {
            switchCam = 4;
        }
        if (flag)
        {
            switchCam = 3;
        }
        if (susroom)
        {
           
            switchCam = 2;
        }  
        if (rope)
        {
            
            switchCam = 5;
        }  
        if (crate)
        {
            
            switchCam = 6;
        }   
        if (bait)
        {
            switchCam = 7;
        }
        if (none)
        {
            switchCam = 1;
        }

        switch (switchCam)
        {
            case 2:
                susroomCam.SetActive(true);
                //susroomExterior.SetActive(false);
                boatCamMain.SetActive(false);
                break;
            case 3:
                flagCam.SetActive(true);
                boatCamMain.SetActive(false);
                break;
            case 1:
                flagCam.SetActive(false);
                susroomCam.SetActive(false);
                boatCamMain.SetActive(true);
                deadBodyCam.SetActive(false);
                break;
            case 4:
                deadBodyCam.SetActive(true);
                boatCamMain.SetActive(false);
                break;
            case 5:
                ropeCam.SetActive(true);
                boatCamMain.SetActive(false);
                break;
            case 6:
                crateCam.SetActive(true);
                boatCamMain.SetActive(false);
                break;
            case 7:
                baitCam.SetActive(true);
                boatCamMain.SetActive(false);
                break;
            default:
                break;
        }



    }
    public void susRoomActive()
    {
        susroom = true;
        none = false;

    }

    public void flagActive()
    {
        flag = true;
        none = false;
    } 
    public void DeadBodyActive()
    {
        deadbody = true;
        none = false;
    }  
    public void CrateActive()
    {
        crate = true;
        none = false;
    }   
    public void RopeActive()
    {
        rope = true;
        none = false;
    }  
    public void BaitActive()
    {
        bait = true;
        none = false;
    }
    public void MainBoatActive()
    {
        susroom = false;
        flag = false;
        none = true;
        crate = false;
        rope = false;
        bait = false;
    }

}
