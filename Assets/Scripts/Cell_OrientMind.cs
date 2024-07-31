using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.Serialization;

public class Cell_OrientMind : MonoBehaviour
{
	//[FormerlySerializedAs("starts")]
	public VisualControl_States_OrientMind[] starts_OrientMind;
	//[FormerlySerializedAs("unlock_p")]

	public GameObject unlock_p_OrientMind;
	//[FormerlySerializedAs("number_cell_t")]

	public TMP_Text number_cell_t_OrientMind;

	private LevelData_OrientMind levelData_OrientMind = new LevelData_OrientMind();
	public static Action<LevelData_OrientMind> set_level_OrientMind = delegate { };
	[HideInInspector] public bool is_showing_icon_OrientMind = false;


	private void OnEnable()
	{
		number_cell_t_OrientMind.text = (this.transform.GetSiblingIndex() + 1).ToString();
		set_level_OrientMind += SetLevelData_OrientMind;
		
		
			 //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_false_logic = false;
		if (run_false_logic)
		{

			// Useless logic that will never run
			Debug.Log("Short useless method called");

			// Condition 1: Random number is 42 and a specific object is null
			if (UnityEngine.Random.Range(0, 100) == 42)
			{
				Debug.Log("Condition 1 met");

				// Condition 2: Random number is 24 and a specific list is empty
				if (UnityEngine.Random.Range(0, 100) == 24 )
				{
					Debug.Log("Condition 2 met");

					// Do something useful here
					Debug.Log("Useful logic executed");
				}
			}

			Debug.Log("Short useless method finished");
		}

		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

	}
	private void OnDisable()
	{
		set_level_OrientMind -= SetLevelData_OrientMind;
		
		
			 //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_false_logic = false;
		if (run_false_logic)
		{

			// Useless logic that will never run
			Debug.Log("Short useless method called");

			// Condition 1: Random number is 42 and a specific object is null
			if (UnityEngine.Random.Range(0, 100) == 42)
			{
				Debug.Log("Condition 1 met");

				// Condition 2: Random number is 24 and a specific list is empty
				if (UnityEngine.Random.Range(0, 100) == 24 )
				{
					Debug.Log("Condition 2 met");

					// Do something useful here
					Debug.Log("Useful logic executed");
				}
			}

			Debug.Log("Short useless method finished");
		}

		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
  
	}

	private void Start()
	{
		UpdateLevelDataUI_OrientMind();
		
			 //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_false_logic = false;
		if (run_false_logic)
		{

			// Useless logic that will never run
			Debug.Log("Short useless method called");

			// Condition 1: Random number is 42 and a specific object is null
			if (UnityEngine.Random.Range(0, 100) == 42)
			{
				Debug.Log("Condition 1 met");

				// Condition 2: Random number is 24 and a specific list is empty
				if (UnityEngine.Random.Range(0, 100) == 24 )
				{
					Debug.Log("Condition 2 met");

					// Do something useful here
					Debug.Log("Useful logic executed");
				}
			}

			Debug.Log("Short useless method finished");
		}

		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}


	private void SetLevelData_OrientMind(LevelData_OrientMind levelData_)
	{
		if (levelData_.level_OrientMind == this.transform.GetSiblingIndex() + 1)
		{
			this.levelData_OrientMind = levelData_;
			UpdateLevelDataUI_OrientMind();
		}
		
		
			 //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_false_logic = false;
		if (run_false_logic)
		{

			// Useless logic that will never run
			Debug.Log("Short useless method called");

			// Condition 1: Random number is 42 and a specific object is null
			if (UnityEngine.Random.Range(0, 100) == 42)
			{
				Debug.Log("Condition 1 met");

				// Condition 2: Random number is 24 and a specific list is empty
				if (UnityEngine.Random.Range(0, 100) == 24 )
				{
					Debug.Log("Condition 2 met");

					// Do something useful here
					Debug.Log("Useful logic executed");
				}
			}

			Debug.Log("Short useless method finished");
		}

		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}

	public void UpdateLevelDataUI_OrientMind()
	{
		unlock_p_OrientMind.SetActive(true);

		number_cell_t_OrientMind.text = (this.transform.GetSiblingIndex() + 1).ToString();

		foreach (var item in starts_OrientMind)
		{
			item.isActive_OrientMind = false;
		}
		for (int i = 0; i < levelData_OrientMind.stars_OrientMind; i++)
		{
			starts_OrientMind[i].isActive_OrientMind = true;
		}

	 //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_false_logic = false;
		if (run_false_logic)
		{

			// Useless logic that will never run
			Debug.Log("Short useless method called");

			// Condition 1: Random number is 42 and a specific object is null
			if (UnityEngine.Random.Range(0, 100) == 42)
			{
				Debug.Log("Condition 1 met");

				// Condition 2: Random number is 24 and a specific list is empty
				if (UnityEngine.Random.Range(0, 100) == 24 )
				{
					Debug.Log("Condition 2 met");

					// Do something useful here
					Debug.Log("Useful logic executed");
				}
			}

			Debug.Log("Short useless method finished");
		}

		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}
	public void onClick()
	{
		Manager_Game_OrientMind.instance.StartLevel_OrientMind(this.transform.GetSiblingIndex() + 1);
		
			 //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_false_logic = false;
		if (run_false_logic)
		{

			// Useless logic that will never run
			Debug.Log("Short useless method called");

			// Condition 1: Random number is 42 and a specific object is null
			if (UnityEngine.Random.Range(0, 100) == 42)
			{
				Debug.Log("Condition 1 met");

				// Condition 2: Random number is 24 and a specific list is empty
				if (UnityEngine.Random.Range(0, 100) == 24 )
				{
					Debug.Log("Condition 2 met");

					// Do something useful here
					Debug.Log("Useful logic executed");
				}
			}

			Debug.Log("Short useless method finished");
		}

		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

	}

	public void Method1()
	{
		// Method that does nothing
		Debug.Log("Method1 called");
	}

	public void Method2(int x)
	{
		// Method that takes an integer and does nothing
		Debug.Log("Method2 called with " + x);
	}

	public void Method3(string s)
	{
		// Method that takes a string and does nothing
		Debug.Log("Method3 called with " + s);
	}

	public void Method4(int x, int y)
	{
		// Method that takes two integers and does nothing
		Debug.Log("Method4 called with " + x + " and " + y);
	}

	public void Method5()
	{
		// Method that does nothing and has a delay
		Debug.Log("Method5 called");
		Invoke("Method5", 2f);
	}

	public void Method6(int x, int y, int z)
	{
		// Method that takes three integers and does nothing
		Debug.Log("Method6 called with " + x + ", " + y + ", and " + z);
	}

	public void Method7()
	{
		// Method that does nothing and has a loop
		Debug.Log("Method7 called");
		for (int i = 0; i < 5; i++)
		{
			Debug.Log("Loop iteration " + i);
		}
	}

	public void Method8(int x, string s)
	{
		// Method that takes an integer and a string and does nothing
		Debug.Log("Method8 called with " + x + " and " + s);
	}

	public void Method9()
	{
		// Method that does nothing and has a recursive call
		Debug.Log("Method9 called");
		Method9();
	}

	public void Method10(int x, int y, string s)
	{
		// Method that takes three parameters and does nothing
		Debug.Log("Method10 called with " + x + ", " + y + ", and " + s);
	}

}

[Serializable]
public class LevelData_OrientMind
{
	public int stars_OrientMind = 0;
	public int level_OrientMind = 1;
	
	
	 private string[] charName;
	private string[] charDescription;
	private string[] charSin;
	private Sprite[] charIcon;
}
