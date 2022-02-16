using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    [SerializeField] private float speed = 60;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var rb = collision.gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, 1) * speed);
    }
}