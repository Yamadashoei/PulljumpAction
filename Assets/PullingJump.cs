using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PullingJump : MonoBehaviour
{

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        //rb = GetCompponent<Rigidody>;
    }

    private Vector3 clickPosition;
    [SerializeField]
    private float jumpPower = 10;

    // Update is called once per frame
    void Update()
    {
        ////確認したら削除
        //if(Input.GetKeyDown(KeyCode.Space)) { 
        //rb.velocity = new Vector3(0,10,0);
        //}

        if (Input.GetMouseButtonDown(0))
        {
            //マウス位置の保存
            clickPosition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            //
            Vector3 dist = clickPosition - Input.mousePosition;
            //
            if (dist.sqrMagnitude == 0) { return; }
            rb.velocity = dist.normalized * jumpPower;


        }

    }
}
