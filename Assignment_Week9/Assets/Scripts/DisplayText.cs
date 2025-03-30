using UnityEngine;

public class DisplayText : MonoBehaviour
{
    public int score = 0;
    TMPro.TextMeshProUGUI text;
    void Start()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
        text.text = "Score: " + score + "\n" + "Speed: "+ GameManagement.instance.playerSpeed;
        
    }

    void Update()
    {
        score = GameManagement.instance.playerScore;
        text.text = "Score: " + score + "\n" + "Speed: "+ GameManagement.instance.playerSpeed;
    }
    
}
