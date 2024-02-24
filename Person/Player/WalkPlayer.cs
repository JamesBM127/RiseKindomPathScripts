using UnityEngine;

public class WalkPlayer : Walk
{
    protected void Move()
    {
        attack = animator.GetCurrentAnimatorStateInfo(0).IsName($"Melee-Attack-{animatorDirection}");
        if (!attack)
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            WalkMovimentAndAnimation();
        }
    }
}
