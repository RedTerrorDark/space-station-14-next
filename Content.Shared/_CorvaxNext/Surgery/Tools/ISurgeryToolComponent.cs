namespace Content.Shared._CorvaxNext.Surgery.Tools;

public interface ISurgeryToolComponent
{
    [DataField]
    public string ToolName { get; }

    // Mostly intended for discardable or non-reusable tools.
    [DataField]
    public bool? Used { get; set; }
}
