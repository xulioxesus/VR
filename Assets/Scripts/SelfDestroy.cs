using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public float minTime = 2f;
    public float maxTime = 10f;

    void Start()
    {
        float randomTime = Random.Range(minTime, maxTime);
        Destroy(gameObject, randomTime);
    }
}