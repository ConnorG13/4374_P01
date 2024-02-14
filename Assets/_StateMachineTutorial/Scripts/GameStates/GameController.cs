using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Game Data")]
    [SerializeField] private float _tapLimitDuration = 2.5f;

    [Header("Dependencies")]
    [SerializeField] private Unit _playerUnitPrefab;
    [SerializeField] private Transform _playerUnitSpawn;
    [SerializeField] private UnitSpawner _unitSpawner;
    [SerializeField] private InputBroadcaster _input;

    public float TapLimitDuration => _tapLimitDuration;
    public Unit PlayerUnitPrefab => _playerUnitPrefab;
    public Transform PlayerUnitSpawn => _playerUnitSpawn;
    public UnitSpawner UnitSpawner => _unitSpawner;
    public InputBroadcaster Input => _input;
}