using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TypeWriterNew : MonoBehaviour
{
    Text _text;
	TMP_Text _tmpProText;
	string writer;

	[SerializeField] float delayBeforeStart = 0f;
	[SerializeField] float timeBtwChars = 0.1f;
	[SerializeField] string leadingChar = "";
	[SerializeField] bool leadingCharBeforeDelay = false;

	// Use this for initialization
	void Start()
	{
		_text = GetComponent<Text>()!;
		_tmpProText = GetComponent<TMP_Text>()!;

		if(_text != null)
        {
			writer = _text.text;
			_text.text = "";

			StartCoroutine("TypeWriterText");
		}

		if (_tmpProText != null)
		{
			writer = _tmpProText.text;
			_tmpProText.text = "";

			StartCoroutine("TypeWriterTMP");
		}
	}

	IEnumerator TypeWriterText()
	{
		_text.text = leadingCharBeforeDelay ? leadingChar : "";

		yield return new WaitForSeconds(delayBeforeStart);

		foreach (char c in writer)
		{
			if (_text.text.Length > 0)
			{
				_text.text = _text.text.Substring(0, _text.text.Length - leadingChar.Length);
			}
			_text.text += c;
			_text.text += leadingChar;
			yield return new WaitForSeconds(timeBtwChars);
		}

		if(leadingChar != "")
        {
			_text.text = _text.text.Substring(0, _text.text.Length - leadingChar.Length);
		}
	}

	IEnumerator TypeWriterTMP()
    {
        _tmpProText.text = leadingCharBeforeDelay ? leadingChar : "";

        yield return new WaitForSeconds(delayBeforeStart);

		foreach (char c in writer)
		{
			if (_tmpProText.text.Length > 0)
			{
				_tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);
			}
			_tmpProText.text += c;
			_tmpProText.text += leadingChar;
			yield return new WaitForSeconds(timeBtwChars);
		}

		if (leadingChar != "")
		{
			_tmpProText.text = _tmpProText.text.Substring(0, _tmpProText.text.Length - leadingChar.Length);
		}

		//StartCoroutine(BlinkingCaret());
	}

    /* IEnumerator BlinkingCaret()
    {



		
		TMP_TextInfo textInfo = _tmpProText.textInfo;
		Color32[] newVertexColors;
		Color32 c0 = _tmpProText.color;
        while (true)
        {
			int materialIndex = textInfo.characterInfo[_tmpProText.text.Length].materialReferenceIndex;

            newVertexColors = textInfo.meshInfo[materialIndex].colors32;

            int vertexIndex = textInfo.characterInfo[_tmpProText.text.Length].vertexIndex;

			c0 = new Color32(255, 255, 255, 0);

                newVertexColors[vertexIndex + 0] = c0;
                newVertexColors[vertexIndex + 1] = c0;
                newVertexColors[vertexIndex + 2] = c0;
                newVertexColors[vertexIndex + 3] = c0;

            _tmpProText.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);
			
			yield return new WaitForSecondsRealtime(1);

			c0 = new Color32(255, 255, 255, 255);

                newVertexColors[vertexIndex + 0] = c0;
                newVertexColors[vertexIndex + 1] = c0;
                newVertexColors[vertexIndex + 2] = c0;
                newVertexColors[vertexIndex + 3] = c0;

            _tmpProText.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);

			yield return new WaitForSecondsRealtime(1); 
        } 
    } */
}
