using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityGridStyle : MonoBehaviour {
    [Range(0,2)]public float cellWidth;
    [Range(0, 2)] public float cellHeight;
    [Range(0, 30)] public int maxHorizontal;

    [SerializeField] private List<Transform> objectList = new List<Transform>();

    private int childCount = 0;


    void Awake() {
        Transform tf = GetComponent<Transform>();
        childCount = tf.childCount;

        for (int i = 0; i < childCount; i++) {
            objectList.Add(tf.GetChild(i));
        }
    }

    void Start() {
        sortCell();
    }

    protected void sortCell() {
        float posX = 0, posZ = 0;
        for (int i = 0; i < childCount; i++) {
            Transform ptr = objectList[i];
            ptr.localPosition = new Vector3(posX, 1, posZ);
            posX += ptr.GetComponent<RectTransform>().rect.width + cellWidth;
            if ((i + 1) % maxHorizontal == 0) {
                posZ -= ptr.GetComponent<RectTransform>().rect.height + cellHeight;
                posX = 0;
            }
        }
    }
}
