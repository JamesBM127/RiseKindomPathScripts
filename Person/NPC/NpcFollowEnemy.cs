using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcFollowEnemy : Npc
{
    private Transform objectToFollow;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        objectToFollow = Player.player.transform;
        Move(objectToFollow);
        GetMovimentDirection();
    }
}
