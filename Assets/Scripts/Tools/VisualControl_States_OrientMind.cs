using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using System;
using Coffee.UIExtensions;
using UnityEngine.Events;

public class VisualControl_States_OrientMind : MonoBehaviour
{
	[SerializeField] private VisualStatesUI[] uiSatatesToControl_OrientMind;
	[SerializeField] private UnityEvent onChangeState_OrientMind, onOn_OrientMind, onOff_OrientMind;

	[SerializeField] private bool _isActive_OrientMind = false;
	public bool isActive_OrientMind
	{
		set
		{
			_isActive_OrientMind = value;
			UpdateStateUI_OrientMind();
			onChangeState_OrientMind?.Invoke();
			if (value)
			{
				onOn_OrientMind?.Invoke();
			}
			else
			{
				onOff_OrientMind?.Invoke();
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
		get { return _isActive_OrientMind; }
	}


	private Tween animColor_Text_OrientMind;
	private Tween animColor_Image_OrientMind;

	private void UpdateStateUI_OrientMind()
	{

		if (animColor_Text_OrientMind != null)
			animColor_Text_OrientMind.Kill();

		if (animColor_Image_OrientMind != null)
			animColor_Image_OrientMind.Kill();


		foreach (var uiAccess in uiSatatesToControl_OrientMind)
		{
			if (_isActive_OrientMind)
			{
				if (uiAccess._text != null)
					animColor_Text_OrientMind = DOTween.To(() => uiAccess._text.color, x => uiAccess._text.color = x, uiAccess.color_Enable, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

				if (uiAccess._image_ChangeColor != null)
					animColor_Image_OrientMind = DOTween.To(() => uiAccess._image_ChangeColor.effectColor, x => uiAccess._image_ChangeColor.effectColor = x, uiAccess.color_Enable, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

				if (uiAccess._image != null)
					uiAccess._image.sprite = uiAccess.sprite_Enable;

			}
			else
			{
				if (uiAccess._text != null)
					animColor_Text_OrientMind = DOTween.To(() => uiAccess._text.color, x => uiAccess._text.color = x, uiAccess.color_Disable, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

				if (uiAccess._image_ChangeColor != null)
					animColor_Image_OrientMind = DOTween.To(() => uiAccess._image_ChangeColor.effectColor, x => uiAccess._image_ChangeColor.effectColor = x, uiAccess.color_Disable, 0.3f).SetEase(Ease.Linear).SetUpdate(true);

				if (uiAccess._image != null)
					uiAccess._image.sprite = uiAccess.sprite_Disable;
			}
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

	public void SetState(bool state)
	{
		_isActive_OrientMind = state;
		UpdateStateUI_OrientMind();
	}

	[ContextMenu("Toggle")]
	private void ToggleState_OrientMind()
	{
		isActive_OrientMind = !isActive_OrientMind;

	}

}

[Serializable]
public class VisualStatesUI
{
	public TMP_Text _text;
	public Color color_Enable, color_Disable;
	public UIEffect _image_ChangeColor;
	public Image _image;
	public Sprite sprite_Enable, sprite_Disable;


	private string[] charName;
	private string[] charDescription;
	private string[] charSin;
	private Sprite[] charIcon;
}
