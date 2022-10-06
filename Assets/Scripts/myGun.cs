using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGun : MonoBehaviour
{
    RaycastHit hit;//çarpan ýþýnýn bilgisi
    public GameObject Raypoint; //ýþýnýn baþlangýç noktasý
    public float atesEtmeSikligi; //
    float atesEtmeSuresi;
    public float menzil;
    public AudioSource atesSesi;
    public ParticleSystem atesEfekt;
    public Camera myCam;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.Mouse0) && Time.time > atesEtmeSuresi)
        {
            atesEt();
            atesEtmeSuresi = Time.time + atesEtmeSikligi;
        }


    }


    void atesEt()
    {
        //ýþýnýn çýkýþ yerini kameradan verdik, kamera ýþýný tam olarak ekranýn orta noktasýndan gönderiyor
        //Ayný þekilde canvasta ekranýn tam orta noktasýnda bulunan crosshair ile hiçbir sapma yaþanmamasýný saðladýk
        //ýþýn direkt cross hair ile eþleþiyor ve tamamen isabetli bir atýþ saðlanmýþ oluyor
        if(Physics.Raycast(myCam.transform.position, myCam.transform.forward, out hit, Mathf.Infinity))
        {
            

            atesSesi.Play();
            atesEfekt.Play();
            Destroy(hit.transform.gameObject);

            Debug.Log(hit.transform.name);        
        }


    }
}
