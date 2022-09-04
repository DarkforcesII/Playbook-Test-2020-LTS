using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCube : MonoBehaviour
{
    [SerializeField]
    GameObject cubePrefab;

    [SerializeField]
    Button cubeSpawnerButton;

    [SerializeField]
    Button vrCubeSpawnerButton;

    public void InstantiateCube()
    {
        Instantiate(cubePrefab);
    }


    // Start is called before the first frame update
    void Start()
    {
        cubeSpawnerButton.onClick.AddListener(InstantiateCube);
        vrCubeSpawnerButton.onClick.AddListener(InstantiateCube);
    }
}
