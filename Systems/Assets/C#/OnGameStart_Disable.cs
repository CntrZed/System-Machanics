using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGameStart_Disable : MonoBehaviour
{
    

    void Awake()
    {
        this.gameObject.SetActive(false);//When game start get the gameobject that this script is attached to and disable it.
        
    }

}
