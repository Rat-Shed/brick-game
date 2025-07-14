using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool playerPresent;    
    [SerializeField] GameObject[] bricksToChooseFrom;
    
    void Start()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        if(player == null)
        {
            SpawnPlayer();
        }
       
    }

    public void SpawnPlayer()
    {
        Instantiate(bricksToChooseFrom[Random.Range(0, bricksToChooseFrom.Length)], transform);
    }

    
}
