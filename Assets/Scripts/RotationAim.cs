using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;

public class RotationAim : MonoBehaviour
{
    private Camera mainCam;
    Vector3 mousePos;
    public GameObject flamePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector3 rotation = mousePos - transform.position;
        float zRotation = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, zRotation);


        if (zRotation >= 0)
        {
            flamePrefab.layer = 1;
        }
        else if (zRotation <= 0)
        {
            flamePrefab.layer = -2;
        }


    }
}
