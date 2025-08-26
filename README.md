# Programming Best Practices

## Motivation

This repository represents common programming best practices
by showing before-after side-by-side code advantages/disadvantages.

All of the code is available in last `master` branch commit.

For better usage (such as side-by-side changing view) see the `Usage` title below.


## Terms

**Layers Types**

 - `Domain`: Representing any type of domain logic, opposit to `Application` layer. It is why the code is *useful*
 - `Application`: Representing any type of application logic, opposit to `Domain` layer. It is why the code is existing *that* way
 
 
**Actions**

 - `Addition` or `Expansion`: adding a new `Domain` logic
 - `Refactoring` or `Modification`: changing `Application` logic


**Architecture Types**

 - `Short-Term Benefit`: `Actions` that  usually extremely destructive to the future ones (such as "quick" or "easy")
 - `Long-Term Benefit`: `Actions` that might be some bulky, but saving much resources in long-term ones


**Practices Structure in Repo**:

 - `Initial`: Presenting the default repo state
 - `Mistake`: Showing the `addition` that provides `short-term benefits` only, from the `Initial` point
 - `Escalation`: Presenting the problem of additional `expansion` from the `Mistake` point
 - `Refactoring`: Showing the `refactoring` that provides `long-term benefit` only, from the `Mistake` point
 - `Solution`: Presenting better `domain action` represented in `Escalation`, from the `Refactoring` point
 
 
**Practices Structure Type**
 - `NullConstraint`: Protecting prohibitions for `long-term benegits` implementation; "Don't ever do that" terms
 - `Constraint`: Offers a specific solution  of the particular problem for `long-term benegits`; "patterns"


## Usage
 
### Github
 
Please, navigate to particule practices by the [repo root folder](https://github.com/VladisS-Vostok2000/BestPractices/tree/master/BestPractices).
After reaching the final destination (for example, [Open Closed Principle](https://github.com/VladisS-Vostok2000/BestPractices/tree/master/BestPractices/OOP/SOLID/Open%20Closed%20Principle/!Readme.md)), and follow `!Readme.md` instructions there.


### Local Repo Changes Viewer
 
1. Please, pull down all the repo.

`git pull git@github.com:VladisS-Vostok2000/BestPractices.git`

The code is on `.NET 9 C#` actually, but language must not be so much important here.

2. Open the code by your favorite side-by-side changes viewer (for example, `Visual Studio 2022`)



#### Temp

Practices Structureor explore the the raw code instead