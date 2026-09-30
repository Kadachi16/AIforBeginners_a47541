using UnityEngine;
using UnityEngine.InputSystem;

public class FireShell : MonoBehaviour
{
    public GameObject bullet;
    public GameObject turret;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CalculateTrajectory();
            CreateBullet();
        }
    }

    public void CalculateTrajectory()
    {
        
    }

    public void CreateBullet()
    {
        Instantiate(bullet, turret.transform.position, turret.transform.rotation);
    }
}
