Feature: Login Functionality

  Scenario: Valid Login Credentials
    Given I navigate to the login page
    When I enter valid username 'standard_user' and password 'secret_sauce'
    And I click the login button
    Then I should be redirected to the homepage

  Scenario: Invalid Username
    Given I navigate to the login page
    When I enter invalid username 'user_id' and valid password 'secret_sauce'
    And I click the login button
    Then I should see an error message indicating invalid username

  Scenario: Invalid Password
    Given I navigate to the login page
    When I enter valid username 'standard_user' and invalid password 'user_password'
    And I click the login button
    Then I should see an error message about incorrect password

  Scenario: Empty Fields
    Given I navigate to the login page
    When I leave both username and password fields empty
    And I click the login button
    Then I should see error messages prompting to enter username and password