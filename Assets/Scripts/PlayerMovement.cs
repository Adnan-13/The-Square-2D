using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    float speed;
    [SerializeField]
    float jumpForce;
    private float horizontalMovement;

    private bool onGround;
    [SerializeField]
    Transform btmPos;
    [SerializeField]
    float chkRds;
    [SerializeField]
    LayerMask groundLayer;

    
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        onGround = Physics2D.OverlapCircle(btmPos.position, chkRds, groundLayer);

        if(onGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

    }

    void FixedUpdate()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalMovement * speed, rb.velocity.y);
    }

}
