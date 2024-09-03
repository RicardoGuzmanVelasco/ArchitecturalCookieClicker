using System;
using UnityEngine;

namespace CohesiveAnalysis
{
    
public class View
{
    public CanvasGroup CanvasGroup { get; }

    public bool Show(object ct)
    {
        return true;}

    public string Hide(object ct)
    {
        return null;
    }
}
class TypewriterByCharacter
{
    public bool isShowingText;

    public void SkipTypewriter()
    {
        throw new NotImplementedException();
    }
}
interface ILocalizationService
{
    string GetLocalizedText(string getPhraseText);
}
interface ICancellationTokenProvider{
    public object GetToken();
}

public class DialogueData
{
    public bool Finished { get; }
    public int NumberOfPhrases { get; }

    public string GetPhraseText(int _line)
    {
        return "";
    }

    public string GetFinishedDialogueLine()
    {
        return "";
    }

    public void FinishDialogue()
    {
    }
    
    public Sprite Talker { get; }
}
}