using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoxes : MonoBehaviour
{
    public float Limit;
    [SerializeField] GameObject box;
    Vector2 spawnPosition;
    float spawnTime = 2;
    private void Start()
    {
        StartCoroutine(SpawnBoxess());
    }
    void Update()
    {
         spawnPosition = new Vector2(Random.Range(-Limit, Limit), transform.position.y);
        Mathf.Clamp(spawnTime, 1,2);

    }

    IEnumerator SpawnBoxess()
    {
        
        yield return new WaitForSeconds(spawnTime);
        GameObject objects =  Instantiate(box, spawnPosition, Quaternion.identity);
        objects.transform.localScale = new Vector2(Random.Range(1, 1.8f), objects.transform.localScale.y);
        objects.name = "box";
        spawnTime -= 0.01f;

        StartCoroutine(SpawnBoxess());
    }
}
