using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;

	// Use this for initialization
	void Lateupdate()
    {
        transform.position = new Vector3(Target.position.x, transform.position.y, Target.position.z);
    }
}