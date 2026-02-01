using UnityEngine;

public class levelData : MonoBehaviour
{
	private float clock = 3.0f;
	private float clock2 = 0.5f;
	private int count = 0;
	[SerializeField] GameObject floater;

	[Header("Round1")]
    [SerializeField] Sprite option1Round1;
	[SerializeField] Sprite option2Round1;
	[SerializeField] Sprite option3Round1;
	[SerializeField] Sprite option4Round1;
    [Space]
    [SerializeField] int answerRounder1;
[SerializeField] Sprite floaterRound1;
    [Space]
	[Header("Round2")]
	[SerializeField] Sprite option1Round2;
	[SerializeField] Sprite option2Round2;
	[SerializeField] Sprite option3Round2;
	[SerializeField] Sprite option4Round2;
	[Space]
	[SerializeField] int answerRound2;
	[SerializeField] Sprite floaterRound2;
	[Space]
	[Header("Round3")]
	[SerializeField] Sprite option1Round3;
	[SerializeField] Sprite option2Round3;
	[SerializeField] Sprite option3Round3;
	[SerializeField] Sprite option4Round3;
	[Space]
	[SerializeField] int answerRound3;
	[SerializeField] Sprite floaterRound3;
	
	private void StartRound()
	{

		if (clock2 <= 0)
		{
			clock2 = 0.3f;
			if (count == 0)
			{
				GameObject floaterObj1 = Instantiate(floater);
				floaterObj1.GetComponent<waveMotion>().setSprite(floaterRound1);
				count++;
			}
			else if (count == 1)
			{
				GameObject floaterObj2 = Instantiate(floater);
				floaterObj2.GetComponent<waveMotion>().setSprite(floaterRound2);
				count++;
			}
			else if (count == 2)
			{
				GameObject floaterObj3 = Instantiate(floater);
				floaterObj3.GetComponent<waveMotion>().setSprite(floaterRound3);
				count++;
			}
		}
		else
		{
			clock2 -= Time.deltaTime;
		}
	}
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (clock > 0) {
			clock -= Time.deltaTime;
		}
		else
		{
			StartRound();
		}
    }
}
