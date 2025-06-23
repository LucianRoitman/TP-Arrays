using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color[] colores;
    public Renderer cubeRenderer;
    public int randomColorIndex;

    // Start is called before the first frame update
    void Start()
    {
        ChangeColor();
        InvokeRepeating("ChangeColor", 0.5f, 0.5f);
    }

    void ChangeColor()
    {
        randomColorIndex = Random.Range(0, colores.Length);
        cubeRenderer.material.color = colores[randomColorIndex];
    }

    // Update is called once per frame
    void Update()
    {

    }
}