using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
   public GameObject sculpture;

   private GameObject print;
  
   public void SculpPrint()
   {
      if (print != null){
         Destroy(print);
      }
      print = Instantiate(sculpture, new Vector3(1.764f,0,-0.391f), Quaternion.identity);     
   }
}
