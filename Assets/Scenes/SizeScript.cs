using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeScript : MonoBehaviour
{
    // Escala el cubo
    public void ResizeCube(float sizeMultiplier)
    { transform.localScale = sizeMultiplier * Vector3.one; }
}
