using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class ArrowDraw : MonoBehaviour
{
    [SerializeField]
    private Image arrowImage;
    public Vector3 clickPosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //0:左クリック
        //1:右クリック
        //押した瞬間
        if (Input.GetMouseButtonDown(0))
        {
            //マウス位置の保存
            clickPosition = Input.mousePosition;
            arrowImage.gameObject.SetActive(true);
        }
        //離した瞬間
        if (Input.GetMouseButton(0))
        {
            Vector3 dist = clickPosition - Input.mousePosition;
            //ベクトルの長さを算出p14
            float size = dist.magnitude;
            //ベクトルから角度を算出
            float angleRad = Mathf.Atan2(dist.y, dist.x);
            //矢印の画像をクリックした場所に画像を移動
            arrowImage.rectTransform.position = clickPosition;
            //矢印の画像をベクトルから算出した角度を度数法に変換してZ軸回転
            arrowImage.rectTransform.rotation = Quaternion.Euler(0, 0, angleRad * Mathf.Rad2Deg);
            //矢印の画像の大きさをドラッグした距離に合わせる
            arrowImage.rectTransform.sizeDelta = new Vector2(size, size);

            //Debug.Log(dist);
        }
        if (Input.GetMouseButtonUp(0)){
            arrowImage.gameObject.SetActive(false);
        }
    }
}

//bool Input.GetMouseButtonDown(int button);
//bool Input.GetMouseButtonUp(int button);
//bool Input.GetMouseButton(int button);

//Vector3 Input.mousePosition;
//Vector3 Input.mouseScrollDelta;




// Start is called before the first frame update