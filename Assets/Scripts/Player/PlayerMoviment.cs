using UnityEngine;

public class PlayerMovimentt : MonoBehaviour
{   

    public float speed;

    public Rigidbody rb;

    public float horizontalMultiplier = 2;

    float horizontalInput;

    private void Start()
    {
        
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

    }


} 