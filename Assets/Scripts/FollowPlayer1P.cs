
using UnityEngine;

public class FollowPlayer1P : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position; 
    }
}
