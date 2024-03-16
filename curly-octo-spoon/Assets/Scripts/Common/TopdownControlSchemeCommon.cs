using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TopdownControlSchemeCommon : MonoBehaviour
{
    [SerializeField] public bool ManipulationEnabled = true;
    [SerializeField] public bool MovementEnabled = true;
    [SerializeField] public float tentacleStretchModifier = 1;
    [SerializeField] GameObject[] Tentacles;

    // Declaration of gameobject storage arrays
    // i was going to use a 2d array but they're such a nightmare to work with once you enter the realm of actually having to write the code you designed so i was like "nah fuck it"
    [SerializeField] GameObject[] BackPieces;
    [SerializeField] GameObject[] MidPieces;
    [SerializeField] GameObject[] EndPieces;

    // Monobehaviours

    private void Awake() 
    {

    }

    private void Start() 
    {
        
    }

    private void Update() 
    {
        
    }

    // Local Functions

}

/* 
THINGS TO DO:
    - Make basic tentacle stretching and shit. also functions for them
    - Make code for moving around (technical design nightmare)
    - Make code for manual tentacle manipulation (less nightmarish)
    - Polish and better input support (way easier. hopefully)
*/