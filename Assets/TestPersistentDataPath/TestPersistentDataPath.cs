using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPersistentDataPath : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Debug.Log ("======== 测试写入PersistentDataPath =========");
		Debug.LogErrorFormat ("PersistentDataPath:{0}", Application.persistentDataPath);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
