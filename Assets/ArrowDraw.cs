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

        //0:���N���b�N
        //1:�E�N���b�N
        //�������u��
        if (Input.GetMouseButtonDown(0))
        {
            //�}�E�X�ʒu�̕ۑ�
            clickPosition = Input.mousePosition;
            arrowImage.gameObject.SetActive(true);
        }
        //�������u��
        if (Input.GetMouseButton(0))
        {
            Vector3 dist = clickPosition - Input.mousePosition;
            //�x�N�g���̒������Z�op14
            float size = dist.magnitude;
            //�x�N�g������p�x���Z�o
            float angleRad = Mathf.Atan2(dist.y, dist.x);
            //���̉摜���N���b�N�����ꏊ�ɉ摜���ړ�
            arrowImage.rectTransform.position = clickPosition;
            //���̉摜���x�N�g������Z�o�����p�x��x���@�ɕϊ�����Z����]
            arrowImage.rectTransform.rotation = Quaternion.Euler(0, 0, angleRad * Mathf.Rad2Deg);
            //���̉摜�̑傫�����h���b�O���������ɍ��킹��
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