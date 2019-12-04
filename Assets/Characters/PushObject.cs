using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObject : MonoBehaviour
{
    // Start is called before the first frame update
    public float fuerzaMovimiento = 30.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        GameObject otro = other.gameObject;
        // Intentar ver si tiene un rigidbody2D
        Rigidbody2D rb = otro.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * fuerzaMovimiento) ;
    }
}
