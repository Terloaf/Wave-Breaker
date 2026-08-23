using UnityEngine;
using System.Collections''
public class GameStateManager : MonoBehaviour
{
    private void Update()
    {
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {

    }
}
