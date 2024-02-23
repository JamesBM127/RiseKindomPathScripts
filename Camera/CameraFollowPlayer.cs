using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    void Update()
    {
        Vector3 playerPosition = new Vector3(Player.player.transform.position.x,
                                             Player.player.transform.position.y,
                                            (Player.player.transform.position.z - 100));
        transform.position = playerPosition;
    }
}
