using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Thruster : MonoBehaviour {
    public SteamVR_Action_Single throttle;
    public GameObject thruster;
    public float multiplier;
    public Rigidbody vessel;

    public KeyCode alternateKey;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        float throttleValue = throttle.GetAxis(SteamVR_Input_Sources.Any);

        if (Input.GetKey(alternateKey)) {
            throttleValue = 1f;
        }

        if (throttleValue > 0f) {
            throttleValue *= multiplier;
            print("thruster " + throttleValue);
            //DUMMY Calculate force direction from thruster position
            vessel.AddForceAtPosition(new Vector3(0,throttleValue,0), thruster.transform.position);
        }
    }
}
