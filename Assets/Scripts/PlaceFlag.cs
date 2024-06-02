using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlaceFlag : MonoBehaviour
{
    public Tilemap floorTilemap;
    public GameObject itemPrefab;
    public float itemHeightOffset = -0.5f;  // Adjust this value as needed to make the item visible
    public float spawnDelay = 3.0f;  // Delay in seconds before spawning the item

    void Start()
    {
        StartCoroutine(SpawnItemWithDelay());
    }

    IEnumerator SpawnItemWithDelay()
    {
        yield return new WaitForSeconds(spawnDelay);
        PlaceItemOnRandomFloorTile();
    }

    void PlaceItemOnRandomFloorTile()
    {
        // Get all the positions of the floor tiles
        List<Vector3Int> floorTilePositions = new List<Vector3Int>();

        foreach (var pos in floorTilemap.cellBounds.allPositionsWithin)
        {
            if (floorTilemap.HasTile(pos))
            {
                floorTilePositions.Add(pos);
            }
        }

        if (floorTilePositions.Count == 0)
        {
            Debug.LogError("No floor tiles found to place the item.");
            return;
        }

        // Select a random position
        Vector3Int randomTilePosition = floorTilePositions[Random.Range(0, floorTilePositions.Count)];

        // Convert to world position and add height offset
        Vector3 randomWorldPosition = floorTilemap.CellToWorld(randomTilePosition) + new Vector3(0, 0, itemHeightOffset);

        // Instantiate the item
        Instantiate(itemPrefab, randomWorldPosition, Quaternion.identity);
    }
}
