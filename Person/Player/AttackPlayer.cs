using UnityEngine;

public class AttackPlayer : WalkPlayer
{
    protected void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !attack)
        {
            attack = true;
            AttackAnimation(animator);
        }

        AnimatorClipInfo[] currentAnimatorClipInfo = animator.GetCurrentAnimatorClipInfo(0);
        string currentAnimationName = string.Empty;

        if (currentAnimatorClipInfo.Length > 0)
        {
            currentAnimationName = currentAnimatorClipInfo[0].clip.name;
        }

        if (!animator.GetCurrentAnimatorStateInfo(0).IsName($"Melee-Attack-{animatorDirection}"))
        //{
        //    //animator.SetBool($"Attack {animatorDirection}", false);
        //    attack = false;
        //}
        //if (!currentAnimationName.StartsWith("MeleeAttack"))
        {
            //animator.SetBool($"Attack {animatorDirection}", false);
            attack = false;
        }
        else
        {
            //Debug.Log(attack);
            //Debug.Log(currentAnimationName);
        }
    }
}
