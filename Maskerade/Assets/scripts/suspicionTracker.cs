using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class suspicionTracker : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private Image bar;
	[SerializeField] private int currentSuspicion = 5;
    [SerializeField] private int maxSuspicion = 100;

    [Header("Animation")]
    [SerializeField, Range(0, 0.5f)] private float animationTime = 0.25f;
    private Coroutine _fillRoutine;
    
    private void Start()
    {
        UpdateBar();
    }
    private void UpdateBar()
    {
        if (maxSuspicion <= 0)
        {
            bar.fillAmount = 0;
            return;
        }

        float fillAmount = (float) currentSuspicion / maxSuspicion; 
        bar.fillAmount = fillAmount;
    }

    public bool ChangeSuspicionByAmount(int amount)
    {
        
        currentSuspicion += amount;
        currentSuspicion = Mathf.Clamp(currentSuspicion, 0, maxSuspicion);

        bar.fillAmount = (float)currentSuspicion / maxSuspicion;
        return true;
    }

    private void TriggerFillAnimation()
    {
        float targetFill = (float)currentSuspicion / maxSuspicion;
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
    }
}

