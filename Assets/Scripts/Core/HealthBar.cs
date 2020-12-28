﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ForbiddenReef {
	public class HealthBar : MonoBehaviour {

		public Slider slider;
		// public Gradient gradient;
		// public Image fill;

		public void SetMaxHealth (int maxHealth) {
			slider.maxValue = maxHealth;
			slider.value = maxHealth;

			// fill.color = gradient.Evaluate (1f);
		}

		public void SetCurrentHealth (int currentHealth) {
			slider.value = currentHealth;

		}

	}
}