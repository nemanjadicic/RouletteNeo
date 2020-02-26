# Roulette Neo
**Roulette Neo** is an app that predicts numbers on RNG virtual Roulette games. This repository also contains an algorithm tester for experimenting with different Roulette parameters and variations. All within the Visual Studio solution.

### Key Features:
* The app takes in the consideration the amount of money user has and calculates the "Money Goal" for the given Roulette session. It then tells you what numbers to play, and how much money to put on each number, until the Money Goal has been reached.
* The app simulates subscription based business model, allowing the newly created accounts to only use the app once, after which they're prompted to pay for subscription for further use. However, this can be avoided simply by clicking on one of the three subscription buttons.
* Within the solution, there is also the Algorithm Tester app that allows you to experiment with different Roulette parameters such as tweaking users starting money, one-bet-unit, Roulette session money goal, algorithm gap values, session start spin number and such.

## Getting Started
To be able to use this app you'll need:
* [Visual Studio 2019 Community Edition.](https://visualstudio.microsoft.com/downloads/) The app hasn't been tested on older VS versions.
* Browser, mobile or desktop based virtual Roulette casino game.

### Quick Start
1. Clone the repository to your computer and open Roultte Neo solution in Visual Studio.
2. Press F5 to start the Roulette Neo app.

**To start the algorithm tester:**
1. Clone the repository to your computer and open Roulette Neo solution in Visual Studio.
2. In Solution Explorer, right click on "RouletteNeoAlgorithmTester" project and choose "Set As StartUp Project".
3. Press F5 to start the Roulette Neo app.

## How to use
1. Create your account and sign in.
2. Input the Roulette numbers by pressing the corresponding number button or entering the number in the textbox and pressing the Enter key.
3. The app's Algorithms need input of 37 numbers to calculate expected numbers, after which you'll be prompted to enter the amount of money you're playing Roulette with and the (minimal) one-bet-unit. Example of this would be a User who has 2000$ and puts 1$ on each expected number the app suggests.
4. You're good to go! The app will now tell you what numbers to play and how much money to put on each number.

### How it works
Roulette Neo uses 3 statistical algorithms to determine the optimal expected numbers in any given situation. 
The first algorithm calculates the average number of how many times each Roulette number has happened during the given Roulette session. It then creates a list of all numbers that have happened that specific average amount of time, and by that excluding so called "hot" and "cold" numbers.

The second algorithm then takes our "average happened number list" and narrows it down by calculating the average gap between two instances of each number happening during a roulette session.

The third algorithm then further narrows down potential expected numbers by using the statistical law of global average gap. This law says that, considering the phase of the roulette, global average gap between two instances of any number happening is always the same, reaching maximal value equal to the amount of possibilities of any number happening. In the case of European Roulette, that number is 37. So, the third algorithm calculates the global average gap for the given phase of the current Roulette session and then excludes the numbers that don't satisfy its criteria.

This way the user is presented with a certain amount of "expected numbers" that are somewhat likely to happen within the next several spins.

### Potential issues
Roulette Neo is **designed only for virtual RNG European Roulette games.** It has never been tasted on a real Roulette table, or virtual American Roulette. Using the algorithm tester, I have personally performed over 300000 tests with different parameters and came with an optimal algorithm / parameter combination that gives the user around 45% chance of winning. But **only on virtual RNG based Europen Roulette games.**
