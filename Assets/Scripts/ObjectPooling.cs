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
        instance = this;
    }

    private void Start()
    {
        unitsPooled = new List<GameObject>();

        for(int i = 0; i < unitToPool.Length; i++)
        {
            for(int j = 0; j <amountToPool: j++)
            {
                GameObject unit = Instantiate(unitToPool[i]);
                unit.SetActive(false);
                unitsPooled.Add(unit);
            }
        }
    }

    public GameObject[] GetLighthousePooled()
    {
        GameObject[] lh = new GameObject[amountToPool];
        for (int i = 0; i < amountToPool; i++)
        {
            lh[i] = unitsPooled[i];
        }
        return lh;

    }
}
