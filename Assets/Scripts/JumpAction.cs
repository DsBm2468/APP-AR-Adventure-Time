using UnityEngine;

public class JumpAction : MonoBehaviour
{
    public Rigidbody BMORb;

    [Header("Ajustes de salto del personaje")]
    public float jumpForce = 2f;
    //0.0005f
    //public bool isGrounded = true;

    public void Jump()
    {
        if (isGrounded())
        {
            BMORb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }
}
