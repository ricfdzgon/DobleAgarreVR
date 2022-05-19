using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandsInteractable : XRGrabInteractable
{
    //Referencia al interactable para el agarre de la segunda mano
    public XRSimpleInteractable secondGrabPoint;

    void Start()
    {
        secondGrabPoint.onSelectEntered.AddListener(OnSecondInteractorGrab);
        secondGrabPoint.onSelectExited.AddListener(OnSecondInteractorRelease);
    }

    public void OnSecondInteractorGrab(XRBaseInteractor interactor)
    {
        Debug.Log("Agarro con la segunda mano");
    }


    public void OnSecondInteractorRelease(XRBaseInteractor interactor)
    {
        Debug.Log("Suelto la segunda mano");

    }
}
