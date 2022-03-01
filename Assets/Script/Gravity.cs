using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    /*La force de gravité P exercée sur un objet de masse m situé à la distance R d'un corps céleste,
      dont la masse M est supposée concentrée en son centre de masse (barycentre)a,
    est dirigée vers le centre de l'astre et vaut :

    P = m*g
    P=mg avec :
    g = G *M /R² 
    */
    public float yPreced;
    public double gravityForce; //P
    public double mass; //m
    public double pesanteur; //g
    public double constUniversalGavitation ; //G
    public double earthMass; //M
    public double distanceEarthObject; //R
    void Start()
    {
        yPreced = transform.position.y;
        earthMass = 5.972 * Mathf.Pow(10, 24);
        constUniversalGavitation= 6.674 * Mathf.Pow(10, -11);
    }

    // Update is called once per frame
    void Update()
    {
        distanceEarthObject = 6378140 + transform.position.y;
        pesanteur = constUniversalGavitation * earthMass / Mathf.Pow((float)distanceEarthObject, 2);
        gravityForce = mass * pesanteur;
        transform.position -= new Vector3(0,0.5f*(float)gravityForce+yPreced,0);

        yPreced = transform.position.y;
    }
}
