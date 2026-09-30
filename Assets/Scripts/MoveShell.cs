using UnityEngine;

public class MoveShell : MonoBehaviour
{
    public float speed = 1.0f;

    void LateUpdate()
    {
        this.transform.Translate(0, Time.deltaTime * (speed/2), Time.deltaTime * speed);
    }
}
