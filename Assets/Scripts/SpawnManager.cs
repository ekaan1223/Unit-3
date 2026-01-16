using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    [SerializeField] Vector3 spawnPos = new Vector3(25, 0, 0);
    [SerializeField] float startDelay = 2.0f;
    [SerializeField] float repeatRate = 2.0f;
    
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay , repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }

    
}
