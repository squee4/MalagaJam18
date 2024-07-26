using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class terrainTile : MonoBehaviour
{
    [SerializeField] Vector2Int tilePosition;
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInParent<WorldScrolling>().Add(gameObject, tilePosition);
    }

}
