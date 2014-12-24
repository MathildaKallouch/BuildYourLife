using UnityEngine;
using System.Collections;

public class RendererSortingOrder : MonoBehaviour
{
    public int _order;

    // Use this for initialization
    void OnValidate()
    {
        renderer.sortingLayerID = 0;
        renderer.sortingOrder = _order;
    }
}