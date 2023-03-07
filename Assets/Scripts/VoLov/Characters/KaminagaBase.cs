using Sulvic.VoLov.Characters.Info;
using Sulvic.VoLov.Controls;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sulvic.VoLov.Characters{

	public class KaminagaBase: MonoBehaviour{

		private AnimatorHandler animHandler;
		private KaminagaControls controls;
		public Personality origPersonality, personality;

		private void Start(){
			animHandler = new AnimatorHandler(this);
		}

		private void OnEnable(){
			controls = new KaminagaControls();
			controls.KeyMouse.WalkForward.performed += OnWalkForward;
			controls.KeyMouse.WalkBackward.performed += OnWalkBackward;
			controls.KeyMouse.Sprint.performed += OnSprint;

		}

		public void OnWalkForward(InputAction.CallbackContext ctx){
			
		}

		public void OnWalkBackward(InputAction.CallbackContext ctx){

		}

		public void OnSprint(InputAction.CallbackContext ctx){

		}

	}

}
