using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private BoxCollider2D leftWall;
    [SerializeField] private BoxCollider2D rightWall;

    // Start is called before the first frame update
    private void Start()
    {
        leftWall = GameObject.FindGameObjectWithTag("LeftWall").GetComponent<BoxCollider2D>();
        rightWall = GameObject.FindGameObjectWithTag("RightWall").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(leftWall.bounds.max.x);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var velocity = player.velocity;
        var offset = 2f;
        var position = player.position;
        if(position.x > 0)
            player.MovePosition(new Vector2((leftWall.bounds.center + leftWall.bounds.extents).x + offset, player.position.y));
        else
            player.MovePosition(new Vector2((rightWall.bounds.center - leftWall.bounds.extents).x - offset, player.position.y));
        player.velocity = velocity;
    }
}