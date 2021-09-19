using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // the Transform class has the information of positions
    // a Vector3 has 3 vectors for x, y and z coordinates
    // a Transform needs to be put in Unity
    // offset can be changed in unity
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
