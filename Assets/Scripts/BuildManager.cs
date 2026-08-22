using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

   
    public GameObject lighthousePrefab;


    private GameObject unitToBuild;

    public GameObject GetUnitToBuild()
    {
        return unitToBuild;
    }
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        unitToBuild = lighthousePrefab;
    }

}
