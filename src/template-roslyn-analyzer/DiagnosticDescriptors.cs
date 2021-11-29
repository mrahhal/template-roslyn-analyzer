using Microsoft.CodeAnalysis;

namespace TemplateRoslynAnalyzer;

public static class DiagnosticDescriptors
{
	public static class Categories
	{
		public const string Trivia = nameof(Trivia);
	}

	public static readonly DiagnosticDescriptor T1000_AvoidSomething = new(
		"T1000",
		"Avoid something",
		"Avoid something",
		Categories.Trivia,
		DiagnosticSeverity.Error,
		isEnabledByDefault: true);
}
