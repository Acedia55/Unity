using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public string logText = "195 IQ Ma Dudes";
    public float speed = 2;
    public float health = 10;

    // Use this for initialization
    void Start () {

        Debug.Log(logText);
        ApplyDamage(1);
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(logText);

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.right * speed;


    }
   public void ApplyDamage (float damageToDeal)
    {
        health = health - damageToDeal;
    }
}
