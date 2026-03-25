using UnityEngine;

public class Test23 : MonoBehaviour
{
    public Transform Player;

    float cameraOffset = -10f;

    void Update()
    {
        Vector3 targetPos = new Vector3(Player.transform.position.x, Player.transform.position.y, cameraOffset);
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime);
    }
}
