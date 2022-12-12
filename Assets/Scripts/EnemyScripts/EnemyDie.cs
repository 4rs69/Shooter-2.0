using OtherScripts;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    private HealthController _healthHandler;

    private void Awake()
    {
        _healthHandler = GetComponent<HealthController>();
    }

    private void Start()
    {
        _healthHandler.Died += OnDied;
    }

    private void OnDestroy()
    {
        _healthHandler.Died -= OnDied;
    }

    private void OnDied()
    {
        Destroy(gameObject);
    }
}