using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
   // private Tiles[,] m_TilesArray = new Tiles[6,6];   //이차원 배열

    private Dictionary<string, Tiles> m_TilesDictionary = new Dictionary<string, Tiles>();   //딕셔너리

    private GameObject m_tilePrefab;

    public int m_width = 16;
    public int m_height = 16;
    
    void Start()
    {
        m_tilePrefab = Resources.Load("Prefabs/candyred") as GameObject;

        CreatTiles();
    }

    private void CreatTiles()
    {

        for (int y = 0; y < m_height; y++)
        {
            for (int x = 0; x < m_width; x++)
            {
                string key = x.ToString() + "," +  y.ToString();

                Tiles tile = Instantiate<Tiles>(m_tilePrefab.transform.GetComponent<Tiles>());

                tile.transform.SetParent(this.transform);
                tile.transform.position = new Vector3(x, y, 0);

                m_TilesDictionary.Add(key, tile);
            }
        }
    }
}
