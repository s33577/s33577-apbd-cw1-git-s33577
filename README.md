# s33577-apbd-cw1-git-s33577
Tutorial 2 
Andrew Kotowiecki

## Questions:
## 1. When does Git perform a fast-forward and when is a merge commit created?
When the target branch for example ```main``` has no new commits since the creation of the branch. In this case git moves the pointer of ```main``` branch forward to the latest commit. A merge commit is when two branches contain new commits. The pointer cannot move forward so instead it creates a new commit that combines the histories of the two branches.


## 2. What is the practical difference between merge and rebase?
The difference is how they affect the commit history.
 * Merge combienes two branches 
   Example: 
    ```
    A---B---C--------M  (main)
        \          /
        D---E----     (feature)
    ```
    the history keeps the original branching structure and shows when they have been merged.

 * Git Rebase moves commits from one branch on top of the other one, this creates a linear commit history unlike Merge where the branches split and merge thogheter.

   Example:
    ``` 
    A---B---C---D'---E'
    ```
    moves commits D and E ontop of C.

## 3. How was the conflict resolved in your repository?
Firstly the conflict occure because of changing the same line of code in two diffenet branches. In my repo I created a branch called ```feature-conflict``` and added a line of code, then switched back to the main branch and modifed the same line of code. Trying to merge those two branches created a conflict, with an error code as follows:
```
CONFLICT (content): Merge conflict in ConsoleApp1/ConsoleApp1/Program.cs
Automatic merge failed; fix conflicts and then commit the result.
```
To resolve this isuse I used Rider and reviewed both versions of the code, I decided to keep the main version of the code instead of the code in the ```feature-conflict``` branch. I saved the file and proceeded with the operation ```git add . ```, ```git commit``` and ```git push```.