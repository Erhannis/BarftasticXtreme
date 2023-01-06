using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Thruster : MonoBehaviour {
    public SteamVR_Action_Single directionalThrottle;
    public SteamVR_Action_Single downThrottle;
    public GameObject thruster;
    public float multiplier;
    public Rigidbody vessel;

    public KeyCode alternateKey;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        doDownThrust();
        doDirThrust();
    }

    void applyForce(float force, Vector3 pos, Vector3 dir) {
        
    }

    void doDownThrust() {
        float throttleValue = downThrottle.GetAxis(SteamVR_Input_Sources.Any);
        //print("throttle: " + throttleValue);

        if (Input.GetKey(alternateKey)) {
            throttleValue = 1f;
        }

        if (throttleValue > 0f) {
            throttleValue *= multiplier;
            print("thruster:down " + throttleValue);
            vessel.AddForceAtPosition(new Vector3(0,throttleValue,0), thruster.transform.position);
        }
    }

    //RAINY Combine
    void doDirThrust() {
        float throttleValue = directionalThrottle.GetAxis(SteamVR_Input_Sources.Any);
        //print("throttle: " + throttleValue);

        if (throttleValue > 0f) {
            throttleValue *= multiplier;
            print("thruster:dir " + throttleValue);
            Vector3 dir = new Vector3(0,throttleValue,0);
            dir = thruster.transform.rotation * dir;
            vessel.AddForceAtPosition(dir, thruster.transform.position);
        }
    }
}
