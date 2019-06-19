using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static int playerScoreOne = 0;
    public static int playerScoreTwo = 0;

    public GUISkin textSkin;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public static void Score(string wallName) {
        if (wallName == "rightWall") {
            playerScoreOne += 1;
        } else {
            playerScoreTwo += 1;
        }
    }

    void OnGUI() {
        GUI.skin = textSkin;
        GUI.Label(new Rect(Screen.width / 2 - 150, 25, 100, 100), ""+playerScoreOne);

        GUI.Label(new Rect(Screen.width / 2 + 150, 25, 100, 100), "" + playerScoreTwo);
    }
}
