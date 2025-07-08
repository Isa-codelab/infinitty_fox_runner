
using UnityEditor.Search;
using UnityEngine;

public class CameraFollower : MonoBehaviour

{
    public Transform player;
    Vector3 offset;
    // Start is called before the first frame update
    private void Start()
    {
        offset = transform.position - player.position;
        
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 targetPosition = player.position + offset;
        targetPosition.x = 0;
        transform.position = targetPosition;
    }
}
