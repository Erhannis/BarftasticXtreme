using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BXRig : MonoBehaviour {
    public Rigidbody rig;
    public GameObject centerOfMass;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        rig.centerOfMass = rig.transform.InverseTransformPoint(centerOfMass.transform.position);
    }
}
