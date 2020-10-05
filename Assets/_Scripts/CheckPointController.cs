﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    private Vector2 lastCheckpoint;

    private void Start()
    {
        lastCheckpoint = transform.position;
    }

    public void SetCheckPoint()
    {
        lastCheckpoint = transform.position;
    }

    public void Reset()
    {
        transform.position = lastCheckpoint;
    }
}