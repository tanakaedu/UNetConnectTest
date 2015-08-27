using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CPlayer : NetworkBehaviour {
    public float SPEED = 5.0f;
    private Rigidbody rig = null;

	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer) return;

        Vector3 move = Vector3.zero;
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        rig.velocity = move * SPEED;
	}
}
