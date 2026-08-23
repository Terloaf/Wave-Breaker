using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using System.Collections;
using Unity.VisualScripting;
public class Flames : MonoBehaviour
{
    public Transform target;
    private SpriteRenderer sprite;
    public int damage = 2;

    public float hitDelay = 0.8f;

    public float hitTimer = 0f;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {

        transform.position = target.position;
        transform.rotation = target.rotation;

        if (transform.rotation.z <= 0)
        {
            sprite.sortingOrder = 1;
        }
        if (transform.rotation.z >= 0)
        {
            sprite.sortingOrder = -1;
        }


     
    }

    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if(hitTimer <= 0)
            {
                Damage(collision.transform);

                hitTimer = hitDelay;
            }

            hitTimer -= Time.deltaTime;
        }
    }

    void Damage(Transform enemy)
    {
        EnemyMovement e = enemy.GetComponent<EnemyMovement>();
        e.TakeDamage(damage);
    }
}
