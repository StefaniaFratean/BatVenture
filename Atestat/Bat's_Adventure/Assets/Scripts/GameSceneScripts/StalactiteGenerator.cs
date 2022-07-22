using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactiteGenerator : MonoBehaviour
{
    public Transform levelPart_1;
    public Transform levelPart_Start;
    public Player player ;

    private Vector3 lastEndPosition;
    private const float player_distance_spawn = 150f;

    private void Awake()
    {
        lastEndPosition = levelPart_Start.Find("EndPosition").position;
        SpawnLevelPart();
    }

    private void Update()
    {
        if (Vector3.Distance(player.GetPosition(), lastEndPosition) < player_distance_spawn)
        {
            SpawnLevelPart();

        }
    }

    private void SpawnLevelPart()
    {
        Transform lastLevelPartTransform = SpawnLevelPart(lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }

    private Transform SpawnLevelPart(Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart_1, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }

    

}
