using UnityEngine;
using System.Collections;

public class Goomba : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");

        Player mario = collision.collider.GetComponent<Player>();
        mario.ApplyDamage(2);
    }
}
