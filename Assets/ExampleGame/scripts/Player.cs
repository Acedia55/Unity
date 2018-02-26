using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public string logText = "195 IQ Ma Dudes";
    public float speed = 2
    // Use this for initialization
    void Start () {

        Debug.Log(logText);
        Rigidbody2D rigifBody = GetComponent<Rigidbody2D>();
        
        rigidBody.velocity = Vector2.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
