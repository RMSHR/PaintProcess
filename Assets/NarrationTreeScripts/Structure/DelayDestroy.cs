﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	[AddComponentMenu("Paint/Structure/Delay Destroy")]
	public class DelayDestroy : MonoBehaviour {

		public float delay = 1f;
		
		void Start () {
			Destroy(gameObject, delay);
		}
	}

}