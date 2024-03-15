using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FloppyRenderer : MonoBehaviour
{
    [SerializeField] private LineRenderer _renderer;
    [SerializeField] private List<Transform> _points;

    void Start() 
    {
        _renderer.positionCount = _points.Count;
    }

    void Update()
    {
        _renderer.SetPositions(_points.Select(p=>p.position).ToArray());
    }
}
