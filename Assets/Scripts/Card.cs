using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public GameObject front;
    public GameObject back;

    public Animator anim;

    public SpriteRenderer frontImage;

    int idx = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setting(int number) {
        // 매개변수를 활용하여 외부에서 Setting에 값을 넣어 줄 수 있도록
        idx = number;
        frontImage.sprite = Resources.Load<Sprite>($"rtan{idx}");
        // Resources 폴더 속 Sprite를 Load할 건데, 경로가 (Resources 안에 바로 있어서 이름만 적어 주면 됨)
        // $ 문자는 문자열을 보간(사이를 채우다)된 문자열로 인정해 줌. 
        // 보간된 문자열을 보간 식이 포함될 수 있기 때문에 {} 안에 변수를 넣어 사용할 수 있다.
    }

    public void OpenCard() {
        anim.SetBool("isOpen", true);
        front.SetActive(true);
        back.SetActive(false);
    }
}
