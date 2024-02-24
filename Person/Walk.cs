using UnityEngine;

public class Walk : PersonAnimation
{
    //[HideInInspector]
    public float walkSpeed = 1f;
    protected float horizontal, vertical = 0f;

    protected void WalkMovimentAndAnimation()
    {
        WalkMoviment(horizontal, vertical, walkSpeed);
        WalkAnimation(animator, horizontal, vertical);
    }

    protected void WalkMoviment(float horizontal,
                                float vertical,
                                float speed)
    {
        transform.Translate(new Vector3((horizontal * speed) * Time.deltaTime,
                                        (vertical * speed) * Time.deltaTime,
                                         0));
    }
}
