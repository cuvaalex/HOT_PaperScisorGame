Feature:
    In order to play the Game Rock Paper Scissors
    As a Player
    I want to be able to play against the computer
    Scenario: Player plays Rock
        As a Player
        When I play Rock
        Then I should see the computer play Rock, Paper or Scissors
        
    Scenario: Player plays Paper
        As a Player
        When I play Paper
        Then I should see the computer play Rock, Paper or Scissors
        
    Scenario: Player plays Scissors
        As a Player
        When I play Scissors
        Then I should see the computer play Rock, Paper or Scissors
        
    Scenario: Player plays Rock and Computer plays Scissors
        As a Player
        When I play Rock
        And the computer plays Scissors
        Then I should see "Player wins"
        
    Scenario: Player plays Rock and Computer plays Paper
        As a Player
        When I play Rock
        And the computer plays Paper
        Then I should see "Computer wins"
        
    Scenario: Player plays Rock and Computer plays Rock
        As a Player
        When I play Rock
        And the computer plays Rock
        Then I should see "It's a draw"
        
    Scenario: Player plays Paper and Computer plays Rock
        As a Player
        When I play Paper
        And the computer plays Rock
        Then I should see "Player wins"
        
    Scenario: Player plays Paper and Computer plays Scissors
        As a Player
        When I play Paper
        And the computer plays Scissors
        Then I should see "Computer wins"
        
    Scenario: Player plays Paper and Computer plays Paper
        As a Player
        When I play Paper
        And the computer plays Paper
        Then I should see "It's a draw"
        
    Scenario: Player plays Scissors and Computer plays Paper
        As a Player
        When I play Scissors
        And the computer plays Paper
        Then I should see "Player wins"
        
    Scenario: Player plays Scissors and Computer plays Rock
        As a Player
        When I play Scissors
        And the computer plays Rock
        Then I should see "Computer wins"
        
    Scenario: Player plays Scissors and Computer plays Scissors
        As a Player
        When I play Scissors
        And the computer plays Scissors
        Then I should see "It's a draw"        
        