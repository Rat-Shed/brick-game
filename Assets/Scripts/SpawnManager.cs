using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool playerPresent;
    [SerializeField] GameObject playerToSpawn;
    void Start()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        if(player == null)
        {
            SpawnPlayer(playerToSpawn);
        }
       
    }

    private void SpawnPlayer(GameObject player)
    {
        Instantiate(player, transform);
    }
}
