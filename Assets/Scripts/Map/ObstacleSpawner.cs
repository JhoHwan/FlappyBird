using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    [SerializeField] private float _spawnTime;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnObstacleCoroutine");
        
    }

    private IEnumerator SpawnObstacleCoroutine()
    {
        while (true)
        {
            Vector2 spawnPos = transform.position;
            spawnPos.y = Random.Range(-2.0f, 3.0f);
            GameObject obstacle = Instantiate(_obstaclePrefab, spawnPos, transform.rotation);
            Destroy(obstacle, 10.0f);

            yield return new WaitForSeconds(_spawnTime);
        }
    }
}
