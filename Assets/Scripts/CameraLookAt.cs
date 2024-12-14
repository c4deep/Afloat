using UnityEngine;

public class CameraLookAt : MonoBehaviour
{

    [SerializeField] Transform Camera;
    void Update()
    {
        transform.LookAt(Camera);
    }
}
