using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


//[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;

    public float PlayerSpeed = 4;
    public float JumpSpeed = 7;
    public bool hasJetPack=false;

    public LayerMask groundLayer;

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }
        return false;
    }
    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void MoveLeft()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = -PlayerSpeed;
        physicsBody.velocity = newVelocity;
        transform.eulerAngles = new Vector3 (0, 0, 0);
    }

    public void MoveRight()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = PlayerSpeed;
        physicsBody.velocity = newVelocity;
        transform.eulerAngles = new Vector3(0, 180, 0);
    }

    public void Jump()
    {
        if (!IsGrounded()&& !hasJetPack)
        {
            return;
        }
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.y = JumpSpeed;
        physicsBody.velocity = newVelocity;
    }
}
