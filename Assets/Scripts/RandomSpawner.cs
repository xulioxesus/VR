using UnityEngine;
using UnityEngine.UI;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public Vector3 areaSize = new Vector3(10, 5, 5);
    public int amountToSpawn = 10;

    public Slider slider;

    public void SpawnRandomObject()
    {
        amountToSpawn = (int)slider.value;
        
        for (int i = 0; i < amountToSpawn; i++)
        {
            // Posición aleatoria dentro do volume
            Vector3 randomPos = new Vector3(
                Random.Range(-areaSize.x / 2f, areaSize.x / 2f),
                20,
                Random.Range(-areaSize.z / 2f, areaSize.z / 2f)
            );

            // Elixe prefab aleatorio
            GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];

            // Instanciar no mundo
            Instantiate(prefab, transform.position + randomPos, Quaternion.identity);
        }

    }
}