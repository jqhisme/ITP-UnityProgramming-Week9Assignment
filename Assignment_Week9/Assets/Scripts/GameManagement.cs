using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public static GameManagement instance;
    public int playerScore = 0;
    public float playerSpeed = 1.0f;
    public int onLevel = 1;

    private void Awake() 
    { 
        
        if (instance != null && instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            instance = this; 
        } 
    }       
    void Start()
    {
        
    }

   
    void Update()
    {
        if (playerScore >= 5 && onLevel == 1){
            SceneManager.LoadScene("level2");
            onLevel =2;
        }
    }
}
