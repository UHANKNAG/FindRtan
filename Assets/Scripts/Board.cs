using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject card;

    // Start is called before the first frame update
    void Start()
    {
        // 반복 생성을 위하여 반복문 호출
        for (int i = 0; i < 16; i++) {
            GameObject go = Instantiate(card, this.transform); // Board의 자식으로 생성

            float x = (i % 4) * 1.4f - 2.1f;
            float y = (i / 4) * 1.4f - 3.0f;
            // 몫과 나머지를 이용한 배치 전략

            go.transform.position = new Vector2(x, y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
