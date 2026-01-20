using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Firing : MonoBehaviour
{
    public GameObject bullet;
    public Camera gameCamera;
    public Transform firePoint;
    public float force;
    public LayerMask enemy;

    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f, enemy))
        {
            float distance = hit.distance;
            Points.Instance.PointAdd(5f * distance);
            Destroy(hit.collider.gameObject);
        }
    }
}
