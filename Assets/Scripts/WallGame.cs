using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGame : MonoBehaviour
{
    public List<GameObject> WallPrefabs;


    private void Start()
    {
        InvokeRepeating("SpawnWall", 1, 7);
    }
    public void SpawnWall()
    {
        GameObject wall = WallPrefabs[Random.Range(0, WallPrefabs.Count)];
        Instantiate(wall, transform.position, transform.rotation);
    }
}
