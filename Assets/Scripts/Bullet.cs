using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;

    public int damage = 2;
    public void Seek(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        if(target == null)
        {

            Destroy(gameObject);
            return;
        }

        Vector2 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(Vector2.Distance(transform.position, target.position) <= 0.2f)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);

    }

    void HitTarget()
    {
        Debug.Log("hit");
        Damage(target);
        Destroy(gameObject);
    }

    void Damage (Transform enemy)
    {
        EnemyMovement e = enemy.GetComponent<EnemyMovement>();
        e.TakeDamage(damage);
        Destroy(gameObject);
    }
}
