using System.Collections.Immutable;
using System.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;

namespace TemplateRoslynAnalyzer;

[ExportCodeFixProvider(LanguageNames.CSharp)]
[Shared]
public class AvoidSomethingCodeFixProvider : CodeFixProvider
{
	public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(
		DiagnosticDescriptors.T1000_AvoidSomething.Id);

	public sealed override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	public sealed override Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		return Task.CompletedTask;

		//var title = "Avoid something";
		//context.RegisterCodeFix(
		//	CodeAction.Create(
		//		title,
		//		ct => RemoveSomething(context.Document, root, trivia, ct),
		//		equivalenceKey: title),
		//	context.Diagnostics);
	}
}
