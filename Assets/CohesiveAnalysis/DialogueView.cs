using System;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;


namespace CohesiveAnalysis
{
   public class DialogueView : View
    {
        public event Action OnSkipPhrase;
        public event Action OnShowNextLine;

        [SerializeField]
        private Image icon1 = default;

        [SerializeField]
        private TextMeshProUGUI text;
        [SerializeField]
        private TypewriterByCharacter typeWriter;
        [SerializeField]
        private AudioClip audioSelect = default;

        [Inject]
        private readonly ILocalizationService localizationService = default;
        [Inject]
        private readonly ICancellationTokenProvider ctProvider = default;

        private int currentLine;
        private DialogueData currentDialogue;
        private bool isShowing;

        public void StartDialogue(DialogueData _dialogue, bool _flipIcon = false)
        {
            Debug.Assert(_dialogue != null, "El di�logo no puede ser nulo al llamar a esta funci�n");
            if (isShowing) return;
            isShowing = true;
            _ = base.Show(ctProvider.GetToken());
            PrepareIconTalker(_dialogue.Talker, _flipIcon);
            InitializeDialogue(_dialogue);
            StartToShowDialogue();
        }
        #region StartDialogue Methods
        private void PrepareIconTalker(Sprite talker, bool _flipIcon)
        {
            PrepareImage(talker);
            FlipImage(_flipIcon);
        }

        private void PrepareImage(Sprite talker)
        {
            icon1.enabled = talker != null;
            icon1.sprite = talker;
        }

        private void FlipImage(bool _flipIcon)
        {
            if (_flipIcon)
            {
                icon1.transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                icon1.transform.localScale = new Vector3(1, 1, 1);
            }
        }

        private void InitializeDialogue(DialogueData _dialogue)
        {
            text.text = "";
            currentLine = 0;
            currentDialogue = _dialogue;
        }
        private void StartToShowDialogue()
        {
            if (currentDialogue.Finished)
            {
                currentLine = currentDialogue.NumberOfPhrases;
                ShowLine(currentDialogue.GetFinishedDialogueLine());
            }
            else
            {
                ShowLine(currentLine);
            }
        }
        #endregion

        private void ShowLine(int _line)
        {
            text.text = localizationService.GetLocalizedText(currentDialogue.GetPhraseText(_line));
        }
        private void ShowLine(string line)
        {
            text.text = line;
        }

        #region ShowNextLine Methods
        private void ShowNextLine()
        {
            if (IsTypingText())
            {
                SkipTypingAndShowFullText();
            }
            else
            {
                OnShowNextLine?.Invoke();
                //Tengo que lllevarme esto al evento OnShowNextLine
                //AudioManager.Instance.PlaySFX(audioSelect);
                ShowNextLineOrEndDialogue();
            }
        }

        private void SkipTypingAndShowFullText()
        {
            OnSkipPhrase?.Invoke();
            typeWriter.SkipTypewriter();
        }

        private bool IsTypingText()
        {
            return typeWriter.isShowingText;
        }

        private void ShowNextLineOrEndDialogue()
        {
            if (!IsDialogueFinished())
            {
                currentLine++;
                ShowLine(currentLine);
            }
            else
            {
                EndDialogue();
            }
        }

        public void EndDialogue()
        {
            FinishDialogue();
            _ = Hide(ctProvider.GetToken());
            isShowing = false;
        }

        private void FinishDialogue()
        {
            text.text = "";
            currentDialogue.FinishDialogue();
            currentDialogue = null;
        }

        private bool IsDialogueFinished()
        {
            return currentLine + 1 >= currentDialogue.NumberOfPhrases && !currentDialogue.Finished;
        }

        public void SkipLine()
        {
            Debug.Assert(currentDialogue != null, "Esta funci�n no debe llamarse cuando no hay ning�n di�logo informado");
            if (CanvasGroup.alpha < 1) return;
            ShowNextLine();
        }
        #endregion
    }
}