﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start()
	{
		int[] points = new int[5];

		points[0] = 10;
		points[1] = 20;
		points[2] = 30;
		points[3] = 40;
		points[4] = 50;

		for (int i = 0; i < 5; i++)
		{
			Debug.Log(points[i]);

        }

		int[] points2= { 1, 2, 3, 4, 5 };

			for (int i = points2.Length - 1; 0 <= i; i--)
			{
				Debug.Log(points2[i]);

			}

		}

	// Update is called once per frame
	void Update()
	{

	}
}