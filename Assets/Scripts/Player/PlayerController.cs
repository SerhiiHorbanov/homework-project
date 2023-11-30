using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMovementJump jump;
    [SerializeField] PlayerMovementWalk walk;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            jump.TryJump();
        }

        Vector2 walkDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        walkDirection = Quaternion.AngleAxis(transform.rotation.eulerAngles.y, Vector3.back) * walkDirection;

        walk.walkDirection = walkDirection;
    }
}
