﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillzoneManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * 3 * Time.deltaTime);
    }
}
