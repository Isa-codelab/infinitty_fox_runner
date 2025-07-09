using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public float jumpForce;
    public CapsuleCollider capColl;
    public LayerMask groundLayer;

    public float speed;

    public Rigidbody rb;

    public float horizontalMultiplier = 2;

    float horizontalInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Vector3 forwardMove = speed * Time.fixedDeltaTime * transform.forward;
        Vector3 horizontalMove = horizontalInput * speed * horizontalMultiplier * Time.fixedDeltaTime * transform.right;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (isGrounded() && Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.PageUp))
        {
            rb.AddForce((Vector3.up * 3f + transform.forward * 0.5f)* jumpForce, ForceMode.Impulse);

        }

    }

    private bool isGrounded()
    {

        return Physics.CheckCapsule(capColl.bounds.center, new Vector3(capColl.bounds.center.x, capColl.bounds.min.y,
            capColl.bounds.center.z), capColl.radius * 3f, groundLayer);

    }


} 