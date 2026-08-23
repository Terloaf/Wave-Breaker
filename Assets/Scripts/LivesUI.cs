using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    private void Update()
    {
        livesText.text = "Lives " + PlayerStats.Lives; 
    }
}
