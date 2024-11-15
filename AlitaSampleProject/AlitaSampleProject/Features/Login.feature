Feature: Login Functionality

  Scenario: Valid Login
    Given I navigate to the login page
    When I enter valid credentials
    Then I should be redirected to the products page

  Scenario: Invalid Login
    Given I navigate to the login page
    When I enter invalid credentials
    Then I should see an error message