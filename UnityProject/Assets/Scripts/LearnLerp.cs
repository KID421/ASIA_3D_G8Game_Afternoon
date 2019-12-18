﻿using UnityEngine;

public class LearnLerp : MonoBehaviour
{
    public Transform cube, sphere;

    private void Start()
    {
        Vector3 pos = Vector3.Lerp(cube.position, sphere.position, 0.5f);
        print(pos);
    }
}
