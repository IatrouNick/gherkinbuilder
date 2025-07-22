namespace GherkinBuilder.Models
{
    public class StepDefinition
    {
        public string StepDefinitionType { get; set; } = ""; // Given, When, Then
        public string Expression { get; set; } = "";
        public List<string> Parameters { get; set; } = new();
        public string Folder { get; set; } = ""; // Optional grouping/folder name
    }
}
