using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform cameraTransform;
    private Transform playerTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraTransform = GetComponent<Transform>();
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -10.0f);
    }
}
