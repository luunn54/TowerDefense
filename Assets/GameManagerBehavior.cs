using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour {

    public bool gameOver = false;

    public Text waveLabel;
    public GameObject[] nextWaveLabels;

    public Text goldLabel;

    private int gold;
    public int Gold
    {
        get { return gold; }
        set
        {
            gold = value;
            goldLabel.GetComponent<Text>().text = "GOLD: " + gold;
        }
    }

	// Use this for initialization
	void Start () {
        Gold = 1000;
        Wave = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private int wave;
    public int Wave
    {
        get { return wave; }
        set
        {
            wave = value;
            if (!gameOver)
            {
                for (int i = 0; i < nextWaveLabels.Length; i++)
                {
                    nextWaveLabels[i].GetComponent<Animator>().SetTrigger("nextWave");
                }
            }
            waveLabel.text = "WAVE: " + (wave + 1);
        }
    }
}
