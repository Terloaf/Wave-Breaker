using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
public class Flamethrower : MonoBehaviour
{
    [Header("Stats")]
    public float range = 15f;


    [Header("Use Flames")]
    public GameObject flamePrefab;



    public Transform target;
    public string enemyTag = "Enemy";

    public Transform firePoint;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            Shoot();
        }

    }



    void Shoot()
    {
        Debug.Log("SHOOT");
        
        GameObject flameGo = (GameObject)Instantiate(flamePrefab, firePoint.position, firePoint.rotation);
        Flames flame = flameGo.GetComponent<Flames>();


    }

}

