using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemy;
    
    private void Awake()
    {
        var random = Random.Range(5, 10);
        
        for (var i = 0; i < random; i++)
        {
            var newEnemy = Instantiate(_enemy);
            newEnemy.transform.position = new Vector3(Random.Range(-30, 30), 0f, Random.Range(50, -40));
        }
    }
}