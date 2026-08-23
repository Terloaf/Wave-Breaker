using TMPro;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    private void Update()
    {
        livesText.text = "Lives " + PlayerStats.Lives; 

        if(PlayerStats.Lives <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
