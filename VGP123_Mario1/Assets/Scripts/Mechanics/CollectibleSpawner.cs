using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject[] collectibles;

    public Transform[] spawnPoints;

    void Start()
    {
        SpawnCollectibles();
    }

    void SpawnCollectibles()
    {
        Shuffle(spawnPoints);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            int randomIndex = Random.Range(0, collectibles.Length);
            GameObject collectibleToSpawn = collectibles[randomIndex];

            Instantiate(collectibleToSpawn, spawnPoints[i].position, spawnPoints[i].rotation);
        }
    }

    void Shuffle(Transform[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            Transform temp = array[i];
            array[i] = array[randomIndex];
            array[randomIndex] = temp;
        }
    }
}