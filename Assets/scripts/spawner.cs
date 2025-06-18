using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{
    public GameObject pipePrefab;
    public GameObject coinPrefab; // Prefab for the coin
    public float coinSpawnInterval = 10f; // Time interval between coin spawns
    public float minYCoin = -.5f; // Minimum Y position for the coin
    public float maxYCoin = .5f; // Maximum Y position for the coin
    public float spawnInterval = 3f; // Time interval between spawns
    public float minY = -1f; // Minimum Y position for the pipe
    public float maxY = 1f; // Maximum Y position for the pipe
    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnPipe), spawnInterval, spawnInterval);
        InvokeRepeating(nameof(SpawnCoin), coinSpawnInterval, coinSpawnInterval); // Start spawning coins
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnPipe));
        CancelInvoke(nameof(SpawnCoin)); // Stop spawning coins
    }

    private void SpawnPipe()
    {
        // Randomize the Y position of the pipe within the specified range
        GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        pipe.transform.position += Vector3.up * Random.Range(minY, maxY);
    }

    private void SpawnCoin()
    {
        // Randomize the Y position of the coin within the specified range but make sure it spawns not on the x axis of the pipe
        GameObject coin = Instantiate(coinPrefab, transform.position, Quaternion.identity);
        coin.transform.position += Vector3.up * Random.Range(minYCoin, maxYCoin);
    }
}
