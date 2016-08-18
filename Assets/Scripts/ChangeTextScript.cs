using UnityEngine;
using UnityEngine.UI;

public class ChangeTextScript : MonoBehaviour {

    public Text houseText;

	public void changeHouseText(string newText)
    {
        houseText.text = newText;
    }
}
