using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGun : MonoBehaviour
{
    RaycastHit hit;//�arpan ���n�n bilgisi
    public GameObject Raypoint; //���n�n ba�lang�� noktas�
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
        //���n�n ��k�� yerini kameradan verdik, kamera ���n� tam olarak ekran�n orta noktas�ndan g�nderiyor
        //Ayn� �ekilde canvasta ekran�n tam orta noktas�nda bulunan crosshair ile hi�bir sapma ya�anmamas�n� sa�lad�k
        //���n direkt cross hair ile e�le�iyor ve tamamen isabetli bir at�� sa�lanm�� oluyor
        if(Physics.Raycast(myCam.transform.position, myCam.transform.forward, out hit, Mathf.Infinity))
        {
            

            atesSesi.Play();
            atesEfekt.Play();
            Destroy(hit.transform.gameObject);

            Debug.Log(hit.transform.name);        
        }


    }
}
