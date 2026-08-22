using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling instance;

    [SerializeField] int amountToPool;
    [SerializeField] GameObject[] unitToPool;

    List<GameObject> unitsPooled;

    private void Awake()
    {
        
    }

}
