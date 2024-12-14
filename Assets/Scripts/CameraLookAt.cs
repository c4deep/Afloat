using UnityEngine;

public class CameraLookAt : MonoBehaviour
{

    [SerializeField] Transform Camera;
    void Update()
    {
        Transform.LookAt(Camera);
    }
}
