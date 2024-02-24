using UnityEngine;

public abstract class Person : MonoBehaviour
{
    [HideInInspector]
    public string animatorDirection = "Down";

    [HideInInspector]
    public bool attack = false;

    [HideInInspector]
    public bool isAlive = true;
}
