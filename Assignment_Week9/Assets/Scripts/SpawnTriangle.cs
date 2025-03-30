using UnityEngine;

public class SpawnTriangle : MonoBehaviour
{
    public GameObject triangle;
    public GameObject square;
    void Start()
    {
        
    }


    void Update()
    {  
        if (GameManagement.instance.onLevel == 1){
            if(Random.Range(0, 100) < 1)
                {
                    Instantiate(triangle, new Vector3(Random.Range(-10, 10), Random.Range(-7, 7), 0), Quaternion.identity);
                }
        }else if (GameManagement.instance.onLevel == 2){
            float randomValue = Random.Range(0, 100);
            

            if(randomValue == 0){
                Instantiate(triangle, new Vector3(Random.Range(-10, 10), Random.Range(-7, 7), 0), Quaternion.identity);
            }else if (randomValue == 1){
                Instantiate(square, new Vector3(Random.Range(-10, 10), Random.Range(-7, 7), 0), Quaternion.identity);
            }
            
        }
    }
}
