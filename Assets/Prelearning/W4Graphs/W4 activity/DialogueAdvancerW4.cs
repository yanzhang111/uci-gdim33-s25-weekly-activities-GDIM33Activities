using UnityEngine;
using Unity.VisualScripting;

namespace W4Activity
{
    public class DialogueAdvancerW4 : MonoBehaviour
    {
      
        public static DialogueAdvancerW4 _Instance { get; private set; }

        public DialogueNodeW4 startingDialogue;

        private void Awake()
        {
            if (_Instance != null && _Instance != this)
            {
                Destroy(this);
                return;
            }

            _Instance = this;
        }

        private void Start()
        {
            EventBus.Trigger(VsEventNames.NewDialogueEvent, startingDialogue);
        }

        public void ChooseDialogue(DialogueNodeW4 nextLine)
        {
            EventBus.Trigger(VsEventNames.NewDialogueEvent, nextLine);
        }
    }
}