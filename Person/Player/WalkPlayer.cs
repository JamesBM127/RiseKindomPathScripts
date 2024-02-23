using UnityEngine;

public class WalkPlayer : PersonAnimation
{
    //[HideInInspector]
    public float walkSpeed = 1f;

    protected void Move()
    {
        attack = animator.GetCurrentAnimatorStateInfo(0).IsName($"Melee-Attack-{animatorDirection}");
        if (!attack)
            WalkMovimentAndAnimation();
    }

    private void WalkMovimentAndAnimation()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Walk(ref horizontal, ref vertical, ref walkSpeed);
        WalkAnimation(animator, ref horizontal, ref vertical);
    }
}
