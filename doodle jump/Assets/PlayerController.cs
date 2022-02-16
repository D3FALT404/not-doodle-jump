using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private float inputHorizontal;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        switch(inputHorizontal)
        {
            case 1:
                transform.rotation = Quaternion.Euler(new Vector3(0, 0));
                break;

            case -1:
                transform.rotation = Quaternion.Euler(new Vector3(0, -180));
                break;
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2((speed * inputHorizontal), 0));
    }
}