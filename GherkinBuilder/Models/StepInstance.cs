namespace GherkinBuilder.Models
{
    public class StepInstance
    {
        public StepDefinition Definition { get; set; } = new();
        public List<string> FilledParameters { get; set; } = new();
    }
}
