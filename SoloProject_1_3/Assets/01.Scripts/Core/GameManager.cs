using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    private Dictionary<string, Pool> _pools;

    [SerializeField] private GameObject _bullet;
    private void Awake()
    {
        _pools = new Dictionary<string, Pool>();
        // Pool bulletPool = new Pool(_bullet, transform, 15);
    }
}
