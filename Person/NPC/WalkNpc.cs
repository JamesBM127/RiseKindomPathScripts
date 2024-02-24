using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkNpc : Walk
{
    protected Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        WalkAnimation(animator, horizontal, vertical);
    }

    protected void Move(Transform objectToFollow)
    {
        Vector3 direction = objectToFollow.position - transform.position;
        direction.Normalize();
        transform.position += direction * walkSpeed * Time.deltaTime;

        WalkAnimation(animator, horizontal, vertical);
    }

    protected void GetMovimentDirection()
    {
        Vector3 positionChange = transform.position - lastPosition;

        if (Mathf.Abs(positionChange.x) >
            Mathf.Abs(positionChange.y))
        {
            // Horizontal Moviment
            if (positionChange.x > 0)
            {
                horizontal = 1f;
                vertical = 0f;
            }
            else if (positionChange.x < 0)
            {
                horizontal = -1f;
                vertical = 0f;
            }
        }
        //else if (Mathf.Abs(positionChange.x) <
        //         Mathf.Abs(positionChange.y))
        else
        {
            // Vertical Moviment
            if (positionChange.y > 0)
            {
                vertical = 1f;
                horizontal = 0f;
            }
            else if (positionChange.y < 0)
            {
                vertical = -1f;
                horizontal = 0f;
            }
        }
        //else
        //{
        //    vertical = horizontal = 0f;
        //}

        //Debug.Log($"{horizontal} | {vertical}");
        Debug.Log($"{Mathf.Abs(positionChange.x)} | {Mathf.Abs(positionChange.y)}");
        lastPosition = transform.position;
    }
}
