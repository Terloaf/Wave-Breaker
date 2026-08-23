using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnUnit : MonoBehaviour
{
    [SerializeField] Sprite[] unitSprites;
    [SerializeField] SpriteRenderer unitSilhouette;

    GameObject[] unitToSpawn;


    private void Start()
    {
        unitSilhouette.sprite = null;
    }

    private void Update()
    {
        UnitSilhouettePos();
        AddUnit();
    }
    void UnitSilhouettePos()
    {
        Vector2 cursor = Mouse.current.position.ReadValue();
        Vector2 cursorworldpos = Camera.main.ScreenToWorldPoint(cursor);
        unitSilhouette.transform.position = cursorworldpos;
    }

    public void PickUnit(int unitnum)
    {
        unitSilhouette.sprite = unitSprites[unitnum];

        if (unitnum == 0)
        {
            unitToSpawn = ObjectPooling.instance.GetLighthousePooled();
        }
        if (unitnum == 1)
        {
            unitToSpawn = ObjectPooling.instance.GetBoatPooled();
        }
        else return;

    }

    void AddUnit()
    {
        if(unitSilhouette.sprite != null)
        {
            if (Mouse.current.leftButton.isPressed)
            {
                for(int i = 0; i < unitToSpawn.Length; i++)
                {
                    if (!unitToSpawn[i].activeInHierarchy)
                    {
                        unitToSpawn[i].SetActive(true);
                        unitToSpawn[i].transform.position = (Vector2)unitSilhouette.transform.position;
                        unitSilhouette.sprite = null;
                        break;
                    }
                }
            }
        }
    }
}
