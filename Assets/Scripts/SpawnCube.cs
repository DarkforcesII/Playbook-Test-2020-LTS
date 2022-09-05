using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCube : MonoBehaviour
{
    [SerializeField]
    GameObject cubePrefab;

    // references vr button by default
    // reference mouse button for mouse and keyboard controls
    [SerializeField]
    Button cubeSpawnerButton;

    public void InstantiateCube()
    {
        Instantiate(cubePrefab);
    }


    // Start is called before the first frame update
    void Start()
    {
        cubeSpawnerButton.onClick.AddListener(InstantiateCube);
    }
}
