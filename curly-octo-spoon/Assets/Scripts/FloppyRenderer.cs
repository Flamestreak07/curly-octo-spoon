using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/* IMPORTANT NOTE ABOUT NETWORKING:
    In order for the whole networking thing to work, different instances of the player
    octopus, *of the same blueprint* must be able to be "possessed" by a client each -
    there will not be a separate "ghost octo" type that visually and mechanically
    represents other players

    At least, if i recall how Netcode for gameobjects works

    Basically, just keep in mind that octopi should not be affected by inputs by
    default; maybe have like a bool or something that enables input and "assignment
    to a player" that you have defaulted to true for testing for now

    anyways thats all, have a nice day :thumbsup:
*/
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
        DrawLine();
    }

    void OnDrawGizmos()
    {
        _renderer.positionCount = _points.Count;
        DrawLine();
    }

    private void DrawLine()
    {
        _renderer.SetPositions(_points.Select(p=>p.position).ToArray());
    }
}
