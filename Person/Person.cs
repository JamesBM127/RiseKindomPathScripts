using UnityEngine;

public abstract class Person : MonoBehaviour
{
    [HideInInspector]
    public string animatorDirection = "Down";

    [HideInInspector]
    public bool attack = false;

    [HideInInspector]
    public bool isAlive = true;

    public void Walk(ref float horizontal, 
                     ref float vertical, 
                     ref float speed) 
    {
        transform.Translate(new Vector3((horizontal * speed) * Time.deltaTime,
                                        (vertical * speed) * Time.deltaTime,
                                         0));
    }
}
