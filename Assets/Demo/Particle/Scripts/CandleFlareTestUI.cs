using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleFlareTestUI : MonoBehaviour
{
    public CandleFlare flare1;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnGUI() {
        if (GUI.Button(new Rect(10, 30, 50, 30), "东风")) {
            flare1.increaseWindPower();
        }

        if (GUI.Button(new Rect(10, 70, 50, 30), "西风")) {
            flare1.decreaseWindPower();
        }

        if (GUI.Button(new Rect(10, 110, 50, 30), "增强")) {
            flare1.increaseFlame();
        }

        if (GUI.Button(new Rect(10, 150, 50, 30), "减弱")) {
            flare1.decreaseFlame();
        }
    }
}
