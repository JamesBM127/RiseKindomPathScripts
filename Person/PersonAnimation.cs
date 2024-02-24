using System.Linq;
using UnityEngine;

public class PersonAnimation : Person
{
    protected Animator animator;

    public void WalkAnimation(Animator animator,
                              float horizontal,
                              float vertical)
    {
        SetAllAnimatorParametersFalse(animator);

        #region Set Look Direction
        if (Mathf.Abs(horizontal) > Mathf.Abs(vertical))
        {
            if(horizontal > 0)
                animatorDirection = "Right";
            else
                animatorDirection = "Left";
        }
        else if (Mathf.Abs(horizontal) < Mathf.Abs(vertical))
        {
            if (vertical > 0f)
                animatorDirection = "Up";
            else
                animatorDirection = "Down";
        }
        #endregion

        #region Change Animation
        if (horizontal == 0 && vertical == 0)
            animator.SetBool($"Idle {animatorDirection}", true);
        else
            animator.SetBool($"Walk {animatorDirection}", true);
        #endregion
    }

    public void AttackAnimation(Animator animator)
    {
        SetAllAnimatorParametersFalse(animator);
        animator.SetBool($"Attack {animatorDirection}", true);
    }

    public void SetAllAnimatorParametersFalse(Animator animator,
                                                         params string[] parametersException)
    {
        foreach (AnimatorControllerParameter parameter in animator.parameters)
        {
            if (parametersException.Contains(parameter.name))
                continue;

            animator.SetBool(parameter.name, false);
        }
    }
}
