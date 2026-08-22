using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Flames : MonoBehaviour
{
    private Transform target;
    void Start()
    {

    }
    void Update()
    {
        if (target == null)
        {

            Destroy(gameObject);
            return;
        }


    }

}
