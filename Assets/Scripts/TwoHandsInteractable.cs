using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandsInteractable : XRGrabInteractable
{
    //Referencia al interactable para el agarre de la segunda mano
    public XRSimpleInteractable secondGrabPoint;

    private XRBaseInteractor secondInteractor;

    private Quaternion initialRotation;

    void Start()
    {
        secondGrabPoint.onSelectEntered.AddListener(OnSecondInteractorGrab);
        secondGrabPoint.onSelectExited.AddListener(OnSecondInteractorRelease);

    }

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);

        if (secondInteractor != null)
        {
            selectingInteractor.attachTransform.rotation = GetRotation();
        }
    }

    private Quaternion GetRotation()
    {
        Quaternion targetRotation;

        targetRotation = Quaternion.LookRotation(secondInteractor.transform.position - selectingInteractor.transform.position, selectingInteractor.transform.up);

        return targetRotation;
    }

    public void OnSecondInteractorGrab(XRBaseInteractor interactor)
    {
        Debug.Log("Agarro con la segunda mano");
        secondInteractor = interactor;
    }


    public void OnSecondInteractorRelease(XRBaseInteractor interactor)
    {
        Debug.Log("Suelto la segunda mano");
        secondInteractor = null;

        selectingInteractor.attachTransform.localRotation = initialRotation;
    }

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);
        initialRotation = interactor.attachTransform.localRotation;
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);
    }
}
