using UnityEngine;

public class BallsSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab; 
    [SerializeField] private int _maxBall = 10; 
    
    private GameObject[] spawnedObjects; 
    private int objectCount = 0;

    private void Start()
    {
        spawnedObjects = new GameObject[_maxBall];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (objectCount < _maxBall)
            {
                Vector3 spawnPosition = new Vector3(0f, 2f, 0f);
                SpawnBall(spawnPosition);
            }
        }
    }

    private void SpawnBall(Vector3 spawnPosition)
    {
        GameObject newObject = Instantiate(_ballPrefab, spawnPosition, Quaternion.identity);
        spawnedObjects[objectCount] = newObject;
        objectCount++;
    }
}
