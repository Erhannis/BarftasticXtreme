using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class BXRig : MonoBehaviour {
    public SteamVR_Action_Boolean resetAction;

    public Rigidbody rig;
    public GameObject centerOfMass;

    // Start is called before the first frame update
    void Start() {
        resetAction.AddOnStateDownListener(ResetDown, SteamVR_Input_Sources.Any);
    }

    // Update is called once per frame
    void Update() {
        rig.centerOfMass = rig.transform.InverseTransformPoint(centerOfMass.transform.position);
    }

    public void ResetDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) {
        rig.transform.position = new Vector3(0,0,0);
        rig.transform.rotation = Quaternion.identity;
        rig.velocity = new Vector3(0,0,0);
        rig.angularVelocity = new Vector3(0,0,0);
    }
}
