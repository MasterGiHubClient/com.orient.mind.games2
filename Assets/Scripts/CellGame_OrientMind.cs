using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Serialization;

public class CellGame_OrientMind : MonoBehaviour
{
	public Image image_element_cell_OrientMind;
	public CellGame_OrientMind cell_up_OrientMind;
	public CellGame_OrientMind cell_right_OrientMind;
	public CellGame_OrientMind cell_down_OrientMind;
	public CellGame_OrientMind cell_left_OrientMind;
	public Transform[] directions_to_detect;



	public static Action<Sprite, int> on_set_icon_OrientMind = delegate { };

	private Sprite sprite_cell_OrientMind;

	private void OnEnable()
	{
		on_set_icon_OrientMind += SetUpIconForGame_OrientMind;

	}

	private void OnDisable()
	{
		on_set_icon_OrientMind -= SetUpIconForGame_OrientMind;
		
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

	private void SetUpIconForGame_OrientMind(Sprite icon, int index)
	{
		if (this.transform.GetSiblingIndex() + 1 == index)
		{
			sprite_cell_OrientMind = icon;
			image_element_cell_OrientMind.sprite = sprite_cell_OrientMind;
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

	public void CellOndown()
	{
		Manager_Game_OrientMind.instance?.OnCellSelected(this);
		
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

	public void OnCellDirectionDrag_OrientMind(Directions_OrientMind direction)
	{
		Image image_c = null;
		switch (direction)
		{
			case Directions_OrientMind.up:
				if (cell_up_OrientMind != null)
				{
					image_c = cell_up_OrientMind.image_element_cell_OrientMind;
					cell_up_OrientMind.AssignNewCard_OrientMind(image_element_cell_OrientMind);
					AssignNewCard_OrientMind(image_c);
					cell_up_OrientMind.CheckIfMatch_OrientMind();
				}
				break;
			case Directions_OrientMind.right:
				if (cell_right_OrientMind != null)
				{

					image_c = cell_right_OrientMind.image_element_cell_OrientMind;
					cell_right_OrientMind.AssignNewCard_OrientMind(image_element_cell_OrientMind);
					AssignNewCard_OrientMind(image_c);
					cell_right_OrientMind.CheckIfMatch_OrientMind();

				}
				break;
			case Directions_OrientMind.left:
				if (cell_left_OrientMind != null)
				{

					image_c = cell_left_OrientMind.image_element_cell_OrientMind;
					cell_left_OrientMind.AssignNewCard_OrientMind(image_element_cell_OrientMind);
					AssignNewCard_OrientMind(image_c);
					cell_left_OrientMind.CheckIfMatch_OrientMind();

				}
				break;
			case Directions_OrientMind.down:
				if (cell_down_OrientMind != null)
				{

					image_c = cell_down_OrientMind.image_element_cell_OrientMind;
					cell_down_OrientMind.AssignNewCard_OrientMind(image_element_cell_OrientMind);
					AssignNewCard_OrientMind(image_c);
					cell_down_OrientMind.CheckIfMatch_OrientMind();

				}
				break;
		}

		CheckIfMatch_OrientMind();
		//Manager_Game_OrientMind.instance.FinalCheck();
		
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

	public void AssignNewCard_OrientMind(Image card)
	{
		card.transform.parent = this.transform;
		card.transform.DOLocalMove(Vector3.zero, 0.5f);
		image_element_cell_OrientMind = card;
		sprite_cell_OrientMind = card.sprite;
	}

	public void CheckIfMatch_OrientMind()
	{
		List<CellGame_OrientMind> list_cells = new List<CellGame_OrientMind>();
		if (cell_up_OrientMind != null)
			list_cells.Add(cell_up_OrientMind);
		if (cell_right_OrientMind != null)
			list_cells.Add(cell_right_OrientMind);
		if (cell_left_OrientMind != null)
			list_cells.Add(cell_left_OrientMind);
		if (cell_down_OrientMind != null)
			list_cells.Add(cell_down_OrientMind);

		Manager_Game_OrientMind.instance.CheckIfMatchs_OrientMind(list_cells, this);

	}
	Tween anim_image_OrientMind;
	public void InvokeNewIcon()
	{
		if (anim_image_OrientMind != null)
			anim_image_OrientMind.Kill();

		anim_image_OrientMind = image_element_cell_OrientMind.transform.DOScale(0, 0.05f).OnComplete(() =>
		{
			image_element_cell_OrientMind.sprite = Manager_Game_OrientMind.instance.GetRandomSprite();
			image_element_cell_OrientMind.transform.DOScale(1, 0.3f).SetEase(Ease.InOutElastic);
		});
	}
	public List<CellGame_OrientMind> GetCells_OrientMind()
	{
		List<CellGame_OrientMind> list_cells = new List<CellGame_OrientMind>();
		if (cell_up_OrientMind != null)
			list_cells.Add(cell_up_OrientMind);
		if (cell_right_OrientMind != null)
			list_cells.Add(cell_right_OrientMind);
		if (cell_left_OrientMind != null)
			list_cells.Add(cell_left_OrientMind);
		if (cell_down_OrientMind != null)
			list_cells.Add(cell_down_OrientMind);

		return list_cells;
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

public enum Directions_OrientMind
{
	up,
	right,
	left,
	down
}
