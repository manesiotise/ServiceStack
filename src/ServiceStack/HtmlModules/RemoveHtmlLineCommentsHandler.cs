using System;

namespace ServiceStack.HtmlModules;

/// <summary>
/// Remove comments with '-', e.g:
/// <!---: comments are removed -->
/// </summary>
public class RemoveHtmlLineCommentsHandler : IHtmlModulesHandler
{
    public string Name => "-";
    public ReadOnlyMemory<byte> Execute(HtmlModuleContext ctx, string args) => default;
}
