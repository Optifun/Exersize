using Player;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class EntryPoint : MonoBehaviour
{
    [SerializeField] private GameObject PlayerPrefab;
    [SerializeField] private PlayerProps PlayerProps;

    private GameObject player;

    private void Awake()
    {
        player = GameObject.Instantiate(PlayerPrefab);
        player.GetComponent<HealthComponent>().Initialize(PlayerProps.HealthPoints);
    }
}