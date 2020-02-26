using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start()
	{
		int[] points = { 1, 2, 3, 4, 5 };

		for (int i = 0; i < 5; i++)
		{
			Debug.Log(points[i]);

        }
        for (int a = points.Length - 1; 0 <= a; a--)
			{
				Debug.Log(points[a]);

			}

		}

	// Update is called once per frame
	void Update()
	{

	}
}