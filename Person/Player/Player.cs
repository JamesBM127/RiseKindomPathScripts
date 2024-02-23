using UnityEngine;

public class Player : AttackPlayer
{
    public static Player player;

    void Start()
    {
        player = this;
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        Move();
        Attack();
    }
}
