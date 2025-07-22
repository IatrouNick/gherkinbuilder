using GherkinBuilder.Models;

namespace GherkinBuilder.Services
{
    public class StepLibraryService
    {
        private List<StepDefinition> _stepDefinitions = new();

        public void Load(List<StepDefinition> steps)
        {
            _stepDefinitions = steps;
        }

        public IEnumerable<StepDefinition> GetStepsByType(string type)
        {
            return _stepDefinitions.Where(s => s.StepDefinitionType.Equals(type, StringComparison.OrdinalIgnoreCase));
        }
        public IEnumerable<StepDefinition> GetAllSteps()
        {
            return _stepDefinitions;
        }
    }
}
