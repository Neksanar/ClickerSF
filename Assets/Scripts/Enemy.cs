using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Где создать.
    [SerializeField] private Transform _spawnPoint;
    
    //Что создать.
    [SerializeField] private GameObject _enemyPrefab;
    
    private GameObject _enemy;
    
    public TargetClick Gesture;
    
    private void Start()
    {
        _enemy = Instantiate( _enemyPrefab, _spawnPoint.position, Quaternion.identity);

        Gesture = _enemy.GetComponent<TargetClick>();
    }
}
