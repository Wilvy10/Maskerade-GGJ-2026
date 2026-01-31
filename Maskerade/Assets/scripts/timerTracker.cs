using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class timerTracker : MonoBehaviour
{
	[Header("Settings")]
	[SerializeField] private Image bar;
	[SerializeField] private float currentTime = 0.0f;
	[SerializeField] private float maxTime = 10.0f;
	private bool clockOn = true;

	public void resetCurrentTime()
	{
		currentTime = 0.0f;
	}

	private void startTimer()
	{
		clockOn = true;
	}

	private void Update()
	{
		if (clockOn)
		{
			if (currentTime + Time.deltaTime > maxTime)
			{
				clockOn = false;
				bar.fillAmount = 1;
				//check answer
			}
			else
			{
				currentTime += Time.deltaTime;
				bar.fillAmount = currentTime / maxTime;
			}
		}
	}
	//private void UpdateBar()
	//{
	//	if (maxTime <= 0)
	//	{
	//		bar.fillAmount = 1;
	//		return;
	//	}

	//	float fillAmount = currentTime / maxTime;
	//	bar.fillAmount = fillAmount;
	//}

	//public bool ChangeSuspicionByAmount(int amount)
	//{

	//	currentSuspicion += amount;
	//	currentSuspicion = Mathf.Clamp(currentSuspicion, 0, maxTime);

	//	bar.fillAmount = (float)currentSuspicion / maxTime;
	//	if (currentSuspicion == maxTime)
	//	{
	//		//game over
	//	}
	//	return true;
	//}
	/*
	private void TriggerFillAnimation()
	{
		float targetFill = (float)currentSuspicion / maxTime;
		if (Mathf.Approximately(bar.fillAmount, targetFill))
			return;
		if (_fillRoutine != null)
			StopCoroutine(_fillRoutine);

		_fillRoutine = StartCoroutine(SmoothlyTransitionToNewValue(targetFill));
	}

	private IEnumerator SmoothlyTransitionToNewValue(float targetFill)
	{
		float originFill = bar.fillAmount;
		float elapsedTime = 0.0f;
		while (elapsedTime < animationTime)
		{
			elapsedTime += Time.deltaTime;
			float time = elapsedTime / animationTime;
			bar.fillAmount = Mathf.Lerp(originFill, targetFill, time);
			yield return null;
		}
		bar.fillAmount = targetFill;
	}*/
}

