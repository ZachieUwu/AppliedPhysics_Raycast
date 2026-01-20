using UnityEngine;

public class SampleRaycastNormal : MonoBehaviour
{
    public Transform objectPlace;
    public Camera gameCam;

    private void Update()
    {
        Ray ray = gameCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            objectPlace.position = hit.point;
            objectPlace.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
        }
    }
}
