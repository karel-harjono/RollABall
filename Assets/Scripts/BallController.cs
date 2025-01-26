using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;
    [SerializeField] private float jumpForce = 2f;
    private bool isJumping = false;

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

    public void JumpBall()
    {
        if (!isJumping)
        {
            sphereRigidbody.AddForce(Vector3.up *  jumpForce, ForceMode.Impulse);
            isJumping = true ;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

    }
}
