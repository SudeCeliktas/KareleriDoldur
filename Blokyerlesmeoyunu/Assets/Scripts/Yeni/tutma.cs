using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutma : MonoBehaviour
{
    public skormanager Scoremanageer;
    public Vector2 baslang�cpos;
    public GameObject Mouse;
    public Vector2 mouse;
    public Vector2 Screen;
    public Camera cam;
    public Collider2D[] col;
    public GameObject[] kare;
    public int sekil;
    public bool onslot = false;
    //�ekil 1 parcano:5 �ekil 2 parcano:4 sekil 3 parcano:2
    //sekil 4 parcano1 Sekil 5 parcano8 Sekil6 Parcano6 sekil7 parcano:4
    //sekil 8 parcano:3 sekil 9 parcano:9 sekil 10 parcano:7 sekil 11 parcano:12
    //sekil 12 parcano 11 sekil 13 parcano:10
    public Kare[] Kare;
    private void Start()
    {
        baslang�cpos= transform.position;
     
        if(sekil == 1)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
        }
        if (sekil == 2)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;

        }
        if (sekil == 3)
        {
            col[0].enabled = true;
            col[1].enabled = true;

        }
        if (sekil == 4)
        {
            col[0].enabled = true;
           
        }
        if (sekil == 5)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
        }
        if (sekil == 6)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
        }
        if (sekil == 7)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;

        }
        if (sekil == 8)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;

        }
        if (sekil == 9)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
        }
        if (sekil == 10)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
        }
        if (sekil == 11)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
        }
        if (sekil == 12)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            col[4].enabled = true;
        }
        if (sekil == 13)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
        }
        //oyun ba�lada��nda par�al�n Collider2D sini a��yorum

    }
    void Update()
    {

   
        Screen = cam.ScreenToWorldPoint(Input.mousePosition);

        Mouse.transform.position = Screen;
        //Mouse dan pozisyon girdisi al�yorum
    }

    private void OnMouseDown()
    {
        if (sekil == 1)
        {
            kare[0].transform.localPosition = new Vector2(-0.82f, -1.07f);
            kare[1].transform.localPosition = new Vector2(0.816309f, -1.07f);
            kare[2].transform.localPosition = new Vector2(-0.8199997f, 0.556829f);
            kare[3].transform.localPosition = new Vector2(0.816309f, 0.556829f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 2)
        {
            kare[0].transform.localPosition = new Vector2(-2.172999f, 0.04982901f);
            kare[1].transform.localPosition = new Vector2(-2.173f, -1.577f);
            kare[2].transform.localPosition = new Vector2(-0.5366907f, -1.577f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 3)
        {
            kare[0].transform.localPosition = new Vector2(-0.7400001f, 0.05999994f);
            kare[1].transform.localPosition = new Vector2(0.896309f, 0.05999994f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 4)
        {
            kare[0].transform.localPosition = new Vector2(0f, 0f);
         
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
      
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 5)
        {
            kare[0].transform.localPosition = new Vector2(0.22f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(0.22f, -1.56f);
            kare[2].transform.localPosition = new Vector2(0.2200003f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(-1.42f, -1.560001f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 6)
        {
            kare[0].transform.localPosition = new Vector2(0.8800001f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(-0.7599993f, 0.0668292f);
            kare[2].transform.localPosition = new Vector2(0.8800004f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(-0.7599998f, -1.56f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 7)
        {
            kare[0].transform.localPosition = new Vector2(0.6400006f, -0.73f);
            kare[1].transform.localPosition = new Vector2(-1f,-0.7431712f);
            kare[2].transform.localPosition = new Vector2(0.6400011f,0.8968291f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 8)
        {
            kare[0].transform.localPosition = new Vector2(-1.68f, 0.2400002f);
            kare[1].transform.localPosition = new Vector2(-0.04369068f, 0.2400002f);
            kare[2].transform.localPosition = new Vector2(1.596309f, 0.2400002f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 9)
        {
            kare[0].transform.localPosition = new Vector2(0.22f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(0.22f, -1.56f);
            kare[2].transform.localPosition = new Vector2(0.2200003f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(1.86f, -1.56f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 10)
        {
            kare[0].transform.localPosition = new Vector2(-0.8399999f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(0.8000004f, 0.0668292f);
            kare[2].transform.localPosition = new Vector2(-0.8399997f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(0.8f, -1.56f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 11)
        {
            kare[0].transform.localPosition = new Vector2(0.1099999f, 0.7999997f);
            kare[1].transform.localPosition = new Vector2(0.1099999f, -0.8400006f);
            kare[2].transform.localPosition = new Vector2(0.1100004f, 2.426829f);
            kare[3].transform.localPosition = new Vector2(0.1099999f, -2.480001f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 12)
        {
            kare[0].transform.localPosition = new Vector2(0.00999999f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(-1.629999f, 0.0668292f);
            kare[2].transform.localPosition = new Vector2(0.01000023f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(1.65f, 0.06682897f);
            kare[4].transform.localPosition = new Vector2(0.01000047f, -1.573171f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            col[4].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 13)
        {
            kare[0].transform.localPosition = new Vector2(0.00999999f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(-1.629999f, 0.0668292f);
            kare[2].transform.localPosition = new Vector2(0.01000023f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(1.65f, 0.06682897f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (Scoremanageer.start1)
        {
  this.transform.position = Mouse.transform.position;
        }
      
        //�ekilin mouse u takip etmesini sa�l�yorum
    }
    private void OnMouseDrag()
    {
        if (sekil == 1)
        {
            kare[0].transform.localPosition = new Vector2(-0.82f, -1.07f);
            kare[1].transform.localPosition = new Vector2(0.816309f, -1.07f);
            kare[2].transform.localPosition = new Vector2(-0.8199997f, 0.556829f);
            kare[3].transform.localPosition = new Vector2(0.816309f, 0.556829f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 2)
        {
            kare[0].transform.localPosition = new Vector2(-2.172999f, 0.04982901f);
            kare[1].transform.localPosition = new Vector2(-2.173f, -1.577f);
            kare[2].transform.localPosition = new Vector2(-0.5366907f, -1.577f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 3)
        {
            kare[0].transform.localPosition = new Vector2(-0.7400001f, 0.05999994f);
            kare[1].transform.localPosition = new Vector2(0.896309f, 0.05999994f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 4)
        {
            kare[0].transform.localPosition = new Vector2(0, 0f);
          
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
           
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 5)
        {
            kare[0].transform.localPosition = new Vector2(0.22f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(0.22f, -1.56f);
            kare[2].transform.localPosition = new Vector2(0.2200003f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(-1.42f, -1.560001f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 6)
        {
            kare[0].transform.localPosition = new Vector2(0.8800001f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(-0.7599993f, 0.0668292f);
            kare[2].transform.localPosition = new Vector2(0.8800004f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(-0.7599998f, -1.56f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 7)
        {
            kare[0].transform.localPosition = new Vector2(0.6400006f, -0.73f);
            kare[1].transform.localPosition = new Vector2(-1f, -0.7431712f);
            kare[2].transform.localPosition = new Vector2(0.6400011f, 0.8968291f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 8)
        {
            kare[0].transform.localPosition = new Vector2(-1.68f, 0.2400002f);
            kare[1].transform.localPosition = new Vector2(-0.04369068f, 0.2400002f);
            kare[2].transform.localPosition = new Vector2(1.596309f, 0.2400002f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 9)
        {
            kare[0].transform.localPosition = new Vector2(0.22f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(0.22f, -1.56f);
            kare[2].transform.localPosition = new Vector2(0.2200003f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(1.86f, -1.56f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 10)
        {
            kare[0].transform.localPosition = new Vector2(-0.8399999f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(0.8000004f, 0.0668292f);
            kare[2].transform.localPosition = new Vector2(-0.8399997f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(0.8f, -1.56f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 11)
        {
            kare[0].transform.localPosition = new Vector2(0.1099999f, 0.7999997f);
            kare[1].transform.localPosition = new Vector2(0.1099999f, -0.8400006f);
            kare[2].transform.localPosition = new Vector2(0.1100004f, 2.426829f);
            kare[3].transform.localPosition = new Vector2(0.1099999f, -2.480001f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 12)
        {
            kare[0].transform.localPosition = new Vector2(0.00999999f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(-1.629999f, 0.0668292f);
            kare[2].transform.localPosition = new Vector2(0.01000023f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(1.65f, 0.06682897f);
            kare[4].transform.localPosition = new Vector2(0.01000047f, -1.573171f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            col[4].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (sekil == 13)
        {
            kare[0].transform.localPosition = new Vector2(0.00999999f, 0.07999992f);
            kare[1].transform.localPosition = new Vector2(-1.629999f, 0.0668292f);
            kare[2].transform.localPosition = new Vector2(0.01000023f, 1.706829f);
            kare[3].transform.localPosition = new Vector2(1.65f, 0.06682897f);
            //par�al�n pozisyonlar�nda sapma olmas�n diye onlar� d�zeltiyorum
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            //biz par�ay� b�rakmadan ba�ka bir slota girmesin die Collider2D yi kapat�yorum
        }
        if (Scoremanageer.start1)
        {
     this.transform.position = Mouse.transform.position;
        }
   
        //�ekilin mouse u takip etmesini sa�l�yorum
    }
    private void OnMouseUp()
    {

        if (sekil == 1)
        {


            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
     else   if (sekil == 2)
        {



            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
        else  if (sekil == 3)
        {




            col[0].enabled = true;
            col[1].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum

        }
        else if (sekil == 4)
        {



            col[0].enabled = true;
           
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
      else  if (sekil == 5)
        {


            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
      else  if (sekil == 6)
        {


            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
        else if (sekil == 7)
        {



            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
        else if (sekil == 8)
        {



            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
        else if (sekil == 9)
        {


            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
        else if (sekil == 10)
        {


            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
        else if (sekil == 11)
        {


            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
        else if (sekil == 12)
        {


            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            col[4].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
        else if (sekil == 13)
        {


            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            //�ekil b�rak�ld���nda bo� bir slota girsin diye Collider2D yi a��yorum
        }
        StartCoroutine(d�n());
      
        //e�er par�a bo� bir yere b�rak�lm�� ya da yar�m tak�lm�� ise onu kendi yerine g�ndermek i�in d�n metodunu �a��r�yorum
    }

   public IEnumerator d�n()
    {
        yield return new WaitForSeconds(0.2f);
        if (sekil == 1)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1 & Kare[2].girdi == 1 & Kare[3].girdi == 1)
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(-0.82f, -1.07f);
                kare[1].transform.localPosition = new Vector2(0.816309f, -1.07f);
                kare[2].transform.localPosition = new Vector2(-0.8199997f, 0.556829f);
                kare[3].transform.localPosition = new Vector2(0.816309f, 0.556829f);
                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 2)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1 & Kare[2].girdi == 1)
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(-2.172999f, 0.04982901f);
                kare[1].transform.localPosition = new Vector2(-2.173f, -1.577f);
                kare[2].transform.localPosition = new Vector2(-0.5366907f, -1.577f);
                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 3)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1)
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(-0.7400001f, 0.05999994f);
                kare[1].transform.localPosition = new Vector2(0.896309f,0.05999994f);

                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 4)
        {
            if (Kare[0].girdi == 1 )
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(0f, 0f);
             

                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 5)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1 & Kare[2].girdi == 1 & Kare[3].girdi == 1)
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(0.22f, 0.07999992f);
                kare[1].transform.localPosition = new Vector2(0.22f, -1.56f);
                kare[2].transform.localPosition = new Vector2(0.2200003f, 1.706829f);
                kare[3].transform.localPosition = new Vector2(-1.42f, -1.560001f);
                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 6)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1 & Kare[2].girdi == 1 & Kare[3].girdi == 1)
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(0.8800001f, 0.07999992f);
                kare[1].transform.localPosition = new Vector2(-0.7599993f, 0.0668292f);
                kare[2].transform.localPosition = new Vector2(0.8800004f, 1.706829f);
                kare[3].transform.localPosition = new Vector2(-0.7599998f, -1.56f);
                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 7)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1 & Kare[2].girdi == 1)
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(0.6400006f, -0.73f);
                kare[1].transform.localPosition = new Vector2(-1f, -0.7431712f);
                kare[2].transform.localPosition = new Vector2(0.6400011f, 0.8968291f);
                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 8)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1 & Kare[2].girdi == 1)
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(-1.68f, 0.2400002f);
                kare[1].transform.localPosition = new Vector2(-0.04369068f, 0.2400002f);
                kare[2].transform.localPosition = new Vector2(1.596309f, 0.2400002f);
                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 9)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1 & Kare[2].girdi == 1 & Kare[3].girdi == 1)
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(0.22f, 0.07999992f);
                kare[1].transform.localPosition = new Vector2(0.22f, -1.56f);
                kare[2].transform.localPosition = new Vector2(0.2200003f, 1.706829f);
                kare[3].transform.localPosition = new Vector2(1.86f, -1.56f);
                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 10)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1 & Kare[2].girdi == 1 & Kare[3].girdi == 1)
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(-0.8399999f, 0.07999992f);
                kare[1].transform.localPosition = new Vector2(0.8000004f, 0.0668292f);
                kare[2].transform.localPosition = new Vector2(-0.8399997f, 1.706829f);
                kare[3].transform.localPosition = new Vector2(0.8f, -1.56f);
                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 11)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1 & Kare[2].girdi == 1 & Kare[3].girdi == 1)
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(0.1099999f, 0.7999997f);
                kare[1].transform.localPosition = new Vector2(0.1099999f, -0.8400006f);
                kare[2].transform.localPosition = new Vector2(0.1100004f, 2.426829f);
                kare[3].transform.localPosition = new Vector2(0.1099999f, -2.480001f);
                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 12)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1 & Kare[2].girdi == 1 & Kare[3].girdi == 1 & Kare[4].girdi == 1 )
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(0.00999999f, 0.07999992f);
                kare[1].transform.localPosition = new Vector2(-1.629999f, 0.0668292f);
                kare[2].transform.localPosition = new Vector2(0.01000023f, 1.706829f);
                kare[3].transform.localPosition = new Vector2(1.65f, 0.06682897f);
                kare[4].transform.localPosition = new Vector2(0.01000047f, -1.573171f);
                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
        if (sekil == 13)
        {
            if (Kare[0].girdi == 1 & Kare[1].girdi == 1 & Kare[2].girdi == 1 & Kare[3].girdi == 1)
            {
                //par�alar yerlerinde mi diye kontrol ediyorum
            }
            else
            {
                kare[0].transform.localPosition = new Vector2(0.00999999f, 0.07999992f);
                kare[1].transform.localPosition = new Vector2(-1.629999f, 0.0668292f);
                kare[2].transform.localPosition = new Vector2(0.01000023f, 1.706829f);
                kare[3].transform.localPosition = new Vector2(1.65f, 0.06682897f);
              
                this.transform.position = baslang�cpos;
                //par�alar yerinde olmdad��� i�in onlar� ba�lang�� noktalar�na g�t�r�yorum
            }
        }
    }
}
