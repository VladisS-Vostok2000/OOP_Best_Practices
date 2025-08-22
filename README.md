# Object Orientired Programming - Best Practices


# Motivation

This repository represent common OOP best practices
by showing before-after refactoring as code advantages.

All of code is available in last `master` branch commit.

For better usage (for example, side-side changing view) see the `Usage` below.


# Terms

**Layers Types**

 - `Domain`: representing any type of domain logic, opposit to `Application` layer. It is why the code is useful
 - `Application`: representing any type of application logic, opposit to `Domain` layer. It is why the code is existing *that* way
 
 
**Actions**

 - `Addition` or `Expansion`: adding a new `Domain` logic
 - `Refactoring` or `Modification`: changing `Application` logic


**Architecture Types**

 - `Short-term Benefit`: lazy or quick `action` that  usually extremely destructive to the future `action`s
  - `Long-term Benefit`: `action`, that might be some bulky, but saving resources in long-term `action`s


**Practices Structure in Repo**:

 - `Initial`: showing the default repo state
 - `Mistake`: showing the `domain` `action` that provides `short-term benefit`s only
 - `Escalation`: presenting the problem of additional `domain` `action` from the `Mistake`
 - `Refactoring`: showing the `refactoring` of `Mistake` that provides `long-term benefit` only
 - `Solution`: presenting fine `domain` `action`
 
**Practices Structure Type**
 - `NullConstraint`: protecting prohibitions for `long-term benegit`s implementation; "how never to do"
 - `Constraint`: offers a specific solution particular problem for `long-term benegit`s; usually "patterns"

# Usage
 
## Github
 
Please, navigate to particule practices by the repo root folder. After reaching the final destination (for example, [https://github.com/VladisS-Vostok2000/OOP_Best_Practices/tree/master/OOPBestPractices/OOP/SOLID/Open%20Closed%20Principle](Open Closed Principle), follow `readme.md` instructions there.
 
## Local Repo Changes Viewer
 
1. Please, pull down all the repo.
 
`git pull git@github.com:VladisS-Vostok2000/OOP_Best_Practices.git`

2. The code is on `.NET 9 C#` actually, but language must not be so much important here.

Open the code by your favorite side-by-side changes viewer (for example, `Visual Studio 2022`)




Practices Structureor explore the the raw code instead