using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCPuzzle : MonoBehaviour
{
    public GameObject puzzle;
    public int answer;
    [Space]
    [Header("puzzle options")]
        public Sprite Option1;
        public Sprite Option2;
        public Sprite Option3;
        public Sprite Option4;
    [Space]
    [Header("floaters")]
    public Sprite floater1;
	public Sprite floater2;
	public Sprite floater3;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		//DontDestroyOnLoad(transform.gameObject);
        //SceneManager.LoadScene("SpeechScene", LoadSceneMode.Additive);

	}

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interacted()
    {
        transform.position = new Vector3(100, 0, 0);
        SceneManager.LoadScene("SpeechScene1");
		

	}
}
