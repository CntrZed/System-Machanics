using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class Door_RandJigle : MonoBehaviour {

    [Serializable]
    public class DoorSettinsOption
    {
        [SerializeField]
        public float openingSpeed = 1;
        public float closingSpeed = 1.3f;
        [Range(0, 1)]
        public float closeStartFrom = 0.6f;
        
        public KeyCode openButton = KeyCode.E; //Button on the keyboard to open the door
        public bool autoClose = false; //Automatically close the door. Forced to true when in AUTOMATIC mode.
    }
    public DoorSettinsOption controls = new DoorSettinsOption ();









    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
