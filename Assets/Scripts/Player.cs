using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        this.transform.position -= Vector3.left * x * 0.1f;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ball")
        {
            Vector3 v = other.rigidbody.velocity;
            Vector3 ballv = Vector3.Normalize(new Vector3(v.x, 1, 1));
            other.rigidbody.velocity = ballv * 50;
        }
    }
}
