﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : aEffect {

	public override void PlayEffect()
	{
		base.PlayEffect();
		
		int thisLevel = SceneManager.GetActiveScene().buildIndex;
       
		SceneManager.LoadScene(thisLevel + 1);
	}
}
