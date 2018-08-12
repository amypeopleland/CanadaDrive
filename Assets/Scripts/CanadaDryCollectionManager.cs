using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanadaDryCollectionManager : MonoBehaviour {
    int canadaDryNum=0;
    
    // Use this for initialization
    void Start() {
        gameObject.GetComponent<Text>().text = canadaDryNum.ToString();
    }

    // Update is called once per frame
    void Update() {
        
    }
    public void addCanadaDryNum()
    {
        canadaDryNum++;
        gameObject.GetComponent<Text>().text = canadaDryNum.ToString();
    }
}
