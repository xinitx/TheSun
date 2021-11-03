using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu]
public class Tiles : TileBase
{
    public string markType = "";
    public Sprite look;

    public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        tileData.sprite = look;
        base.GetTileData(position, tilemap, ref tileData);
    }
}
