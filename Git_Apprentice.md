# Section I: Beginning Git
## Chapter 1: A Crash Course in Git

### Remote Repositories
A remote repository is simply a collection of all the files of a project, hosted somewhere other than you local machine.

### Branches
Branches are, conceptually, copies of the original contents of the repository. You can work in a branch without affecting the original contents of the repository until you are read to merge all your work back together again.

You can see that Git has created a new branch with the command `git branch`. 
To switch to the my-joke branch, execute `git chekcout my-joke`.

### Making and staging changes
Once changes have been made to the file, execute the command `git add somefile`. This tells git to stage the changes you've made to the list of things to add to the repository.

### Committing changes
Commit changes with a **commit message** by executing `git commit -m "Added some stuff"`.

### Pushing your changes

To **push** your local commit to the remove server type `git push --set-upstream origin branch_name`

### Creating a pull request

## Chapter 2: Cloning a repo
