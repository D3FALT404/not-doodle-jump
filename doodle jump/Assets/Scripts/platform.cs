using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    [SerializeField] private float speed = 60;
    [SerializeField] private bool movedCamera;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb;
    private CameraMovment cameraMovment;

    // Start is called before the first frame update
    private void Start()
    {
        cameraMovment = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMovment>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb = rb != null ? rb : collision.gameObject.GetComponent<Rigidbody2D>();
        if(rb.velocity.y <= 0)
        {
            if(movedCamera == false)
            {
                StartCoroutine(cameraMovment.MoveTowards(transform.position.y));
                movedCamera = true;
            }
            var rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(0, 1) * speed);
        }
    }
}