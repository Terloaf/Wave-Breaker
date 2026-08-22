using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Flames : MonoBehaviour
{
    public Transform target;
    private SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
        transform.position = target.position;
        transform.rotation = target.rotation;

        if(transform.rotation.z <= 0)
        {
            sprite.sortingOrder = 1;
        }
        if (transform.rotation.z >= 0)
        {
           sprite.sortingOrder = -1;
        }

    }

}
