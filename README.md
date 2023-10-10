# FantasySlayer

This is a simple console app used to calculate your fantasy football team's win probability given its roster and the opposing team's roster. Each roster should contain the player's name, availability status, position, and projected points.

## TODO's:

- [ ] Implement a better win probablity calculator like this one from [FiveThirtyEight](https://fivethirtyeight.com/methodology/how-our-nba-predictions-work/):
  
  team1 points ^ 2 / (team1 points ^ 2 + team2 points ^ 2)

- [ ] Validate whether a team's roster has the correct number of players for each position and number of players on the bench:
    - 1 QB: Quarter Back
    - 2 RB: Running Back
    - 2 WR: Wide Receiver
    - 1 TE: Tight End
    - 2 WRT: (Wide Receiver, Running Back, or Tight End)
    - 1 K: Kicker
    - 1 DEF: Team Defense
    - Up to 6 players on the bench

- [ ] Determine suggested moves:
  - [ ] Notify me which players are not available to play (e.g. they are injured or on a bye week)
  - [ ] Notify me which players have a lower projected points than their counterparts