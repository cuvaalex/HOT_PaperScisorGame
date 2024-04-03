using HOT.Assessment.RockPaperScissor.Core.Domain.Game;

namespace HOT.Assessment.RockPaperScissor.WebApp.Components;

public class HandViewHelper
{
    public static readonly string? RockIcon = "fa fa-hand-rock-o";
    public static readonly string? ScissorsIcon = "fa fa-hand-scissors-o";
    public static readonly string? PaperIcon = "fa fa-hand-paper-o";
    
    static IDictionary<HandAction, string?> actions = new Dictionary<HandAction, string?>()
    {
        { HandAction.Paper , HandViewHelper.PaperIcon },
        { HandAction.Rock , HandViewHelper.RockIcon },
        { HandAction.Scissors , HandViewHelper.ScissorsIcon}
    };
    
    public static string? GetActionClass(HandAction hand)
    {
        return actions[hand];
    }

}