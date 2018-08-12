using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalRandomManager : MonoBehaviour {
    public List<GameObject> Animal;
    public List<GameObject> GeneratePos;

    int AnimalNum;
    int[] randomAnimalNum=new int[10];
	// Use this for initialization
	void Start () {
        GameObject newGameObj;
        AnimalNum = Animal.Count;
        //Debug.Log(AnimalNum);
        for(int i=0;i< GeneratePos.Count; i++)
        {
            randomAnimalNum[i] = Random.Range(0, AnimalNum);
            //Debug.Log(randomAnimalNum[i]);
           if(Animal[randomAnimalNum[i]].tag=="Bear")
            {
                //Debug.Log("Bear!");
                newGameObj = Instantiate(Animal[randomAnimalNum[i]], new Vector3(GeneratePos[i].transform.position.x, GeneratePos[i].transform.position.y, GeneratePos[i].transform.position.z), Quaternion.identity);
            }
            else
            {

                newGameObj = Instantiate(Animal[randomAnimalNum[i]], new Vector3(GeneratePos[i].transform.position.x, GeneratePos[i].transform.position.y, GeneratePos[i].transform.position.z), Quaternion.identity);

            }
            Quaternion rotData = new Quaternion();
            rotData = GeneratePos[i].transform.rotation;
            newGameObj.transform.rotation = rotData;

            //Debug.Log(GeneratePos[i].transform.position);
        }

        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
