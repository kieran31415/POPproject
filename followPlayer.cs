using UnityEngine;

public class followPlayer : MonoBehaviour
{
    void Start()
    {
        transform.position = player.position + offset;
    }

    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
