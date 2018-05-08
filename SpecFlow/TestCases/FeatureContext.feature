Feature: FeatureContext

@FeatureContext
Scenario: Showing information of the feature
  When I execute any scenario in the feature
  Then the FeatureInfo contains the following information
    | Field          | Value                               |
    | Tags           | showUpInScenarioInfo, andThisToo    |
    | Title          | FeatureContext features             |
    | TargetLanguage | CSharp                              |
    | Language       | en-US                               |
    | Description    | In order to                         |