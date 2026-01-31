using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{   
    [SerializeField]
    private GameObject [] swarmerPrefab;
    //[SerializeField]
    //private GameObject[] bigSwarmerPrefab;

    [SerializeField]
    public float [] swarmerInterval;
    private int number;
    
    
    [SerializeField] private Transform spawnOrigin;

    void Start()
    {
        number=swarmerInterval.Length;
        for (int i=0;i<number;++i)
        {
            StartCoroutine(spawnEnemy(swarmerInterval[i],swarmerPrefab[i]));
        }
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);

        Vector3 originPos = spawnOrigin != null ? spawnOrigin.position : transform.position;
        
        Vector3 spawnPos = originPos + new Vector3(0,0,0);

        GameObject newEnemy = Instantiate(enemy, spawnPos, Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
