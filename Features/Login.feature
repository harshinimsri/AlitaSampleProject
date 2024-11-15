Feature: Login Functionality

  Scenario: Valid Login
    Given I navigate to the login page
    When I enter valid credentials
    And I click the login button
    Then I should be logged in successfully

  Scenario: Invalid Login
    Given I navigate to the login page
    When I enter invalid credentials
    And I click the login button
    Then I should see an error message