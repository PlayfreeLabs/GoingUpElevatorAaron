using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeItOpenButton : MonoBehaviour
{
    public UnityEvent pass1In = new UnityEvent();
    public UnityEvent pass2In = new UnityEvent();
    public UnityEvent pass3In = new UnityEvent();
    public UnityEvent pass4In = new UnityEvent();
    public UnityEvent pass5In = new UnityEvent();
    public UnityEvent pass6In = new UnityEvent();
    public UnityEvent pass7In = new UnityEvent();
    public UnityEvent pass8In = new UnityEvent();
    //out at top events
    public UnityEvent pass1OutTop = new UnityEvent();
    public UnityEvent pass2OutTop = new UnityEvent();
    public UnityEvent pass3OutTop = new UnityEvent();
    public UnityEvent pass4OutTop = new UnityEvent();
    public UnityEvent pass5OutTop = new UnityEvent();
    public UnityEvent pass6OutTop = new UnityEvent();
    public UnityEvent pass7OutTop = new UnityEvent();
    public UnityEvent pass8OutTop = new UnityEvent();
    //out at bot events
    public UnityEvent pass1OutBot = new UnityEvent();
    public UnityEvent pass2OutBot = new UnityEvent();
    public UnityEvent pass3OutBot = new UnityEvent();
    public UnityEvent pass4OutBot = new UnityEvent();
    public UnityEvent pass5OutBot = new UnityEvent();
    public UnityEvent pass6OutBot = new UnityEvent();
    public UnityEvent pass7OutBot = new UnityEvent();
    public UnityEvent pass8OutBot = new UnityEvent();
    public GameObject Openbutton;
    public progression progression;
    // Start is called before the first frame update
    void Start()
    {
        Openbutton = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            //check
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                DeterminePass();
            }
        }
    }
        public void DeterminePass() {
        if (progression.currentPhase == progression.gameState.Waiting) {
            if (progression.getCurrentPass() == 1) {
                pass1In.Invoke();
            }
            if (progression.getCurrentPass() == 2) {
                pass2In.Invoke();
            }
            if (progression.getCurrentPass() == 3) {
                pass3In.Invoke();
            }
            if (progression.getCurrentPass() == 4) {
                pass4In.Invoke();
            }
            if (progression.getCurrentPass() == 5) {
                pass5In.Invoke();
            }
            if (progression.getCurrentPass() == 6) {
                pass6In.Invoke();
            }
            if (progression.getCurrentPass() == 7) {
                pass7In.Invoke();
            }
            if (progression.getCurrentPass() == 8) {
                pass8In.Invoke();
            }
            progression.advancePhase();
        }
        else if (progression.currentPhase == progression.gameState.Arrived && progression.currentPosition == progression.position.top) {
            if (progression.getCurrentPass() == 1) {
                pass1OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 2) {
                pass2OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 3) {
                pass3OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 4) {
                pass4OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 5) {
                pass5OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 6) {
                pass6OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 7) {
                pass7OutTop.Invoke();
            }
            if (progression.getCurrentPass() == 8) {
                pass8OutTop.Invoke();
            }
            progression.advancePhase();
        }
        else if (progression.currentPhase == progression.gameState.Arrived && progression.currentPosition == progression.position.bottom) {
            if (progression.getCurrentPass() == 1) {
                pass1OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 2) {
                pass2OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 3) {
                pass3OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 4) {
                pass4OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 5) {
                pass5OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 6) {
                pass6OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 7) {
                pass7OutBot.Invoke();
            }
            if (progression.getCurrentPass() == 8) {
                pass8OutBot.Invoke();
            }
            progression.advancePhase();
        }
    }
}
