using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class ThirdPersonUserControl : MonoBehaviour
    {
        private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
        private Transform m_Cam;                  // A reference to the main camera in the scenes transform
        private Vector3 m_CamForward;             // The current forward direction of the camera
        private Vector3 m_Move;
        private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
        private bool m_trampolinJump;
        private bool m_crouch;
        public Text StartText;
        
        private void Start()
        {
            // get the transform of the main camera
            if (Camera.main != null)
            {
                m_Cam = Camera.main.transform;
            }
            else
            {
                Debug.LogWarning(
                    "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", gameObject);
                // we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
            }

            // get the third person character ( this should never be null due to require component )
            m_Character = GetComponent<ThirdPersonCharacter>();
        }

        private float h = 0;
        private float v = 0;
        private float pause = 1;

        public void pauseGame(){
            if(pause==1){
                pause=0;
            }else{
                pause=1;
            }
        }

        public void jump()
        {
            if(pause==1)
            {
                m_Jump = true;
            }
        }

        public void crouch(bool act)
        {
            if(pause==1)
            {
                m_crouch = act;
            }
        }

        private void Update()
        {
            if(pause==1)
            {
                if(h==0)
                {
                    if(Input.GetMouseButtonDown(0))
                    {
                        Destroy(StartText.gameObject);
                    }
                }
            }
        }

        public void left(bool act)
        {
            if(pause == 1)
            {
                if(act)
                {
                    h = -1;
                }
                else
                {
                    h = 0;
                }
            }
        }

        public void right(bool act)
        {
            if(pause == 1)
            {
                if(act)
                {
                    h = 1;
                }
                else
                {
                    h = 0;
                }
            }
        }

        public void OnCollisionEnter(Collision other){
            if (other.collider.CompareTag ("Bounce"))
            {
                m_trampolinJump = true;
            }
        }

        // Fixed update is called in sync with physics
        private void FixedUpdate()
        {
            // read inputs
            
            // calculate move direction to pass to character
            if (m_Cam != null)
            {
                // calculate camera relative direction to move:
                m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;
                m_Move = pause*v*m_CamForward + pause*h*0.8f*m_Cam.right;
            }
            else
            {
                // we use world-relative directions in the case of no main camera
                m_Move = v*Vector3.forward + h*Vector3.right;
            }
#if !MOBILE_INPUT
			// walk speed multiplier
	        if (Input.GetKey(KeyCode.LeftShift)) m_Move *= 0.5f;
#endif

            // pass all parameters to the character control script
            m_Character.Move(m_Move, m_crouch, m_Jump, m_trampolinJump);
            m_Jump = false;
            m_trampolinJump = false;
        }
    }
}
