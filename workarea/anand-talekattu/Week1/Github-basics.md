# Github Basics
## Git
Git is a version control system.<br>
Version control system is a tool that helps to track changes in code.<br>

- track the history
- collaborate

## Github
Website that allows developers to store and manage their code using Git.<br>
We call folders in github as repository.

## Basic commands
| Command | Use | 
| --- | --- | 
| git --version | To check the version of the github | 
| git config --global user.name "Anand088" | To set the Git configuration for the user name.<br> The --global flag is used to set the configuration globally for the user, meaning it will apply to all Git repositories on your system | 
| git config --global user.email "anandanand.ec20@rvce.edu.in"  | To set the Git configuration for the user email |
| git config user.name "Anand088"| To set the Git configuration for the user name only for a specific repository|
| git config user.email "anandanand.ec20@rvce.edu.in" | To set the Git configuration for the user email only for a specific repository |
| git config --list| To check the Git credentials for the current repository|
|cd|change directory|
|mkdir| To create a directory|
|ls| used to list the files and directories in the current directory|
|ls -a| used to list all files, including hidden files and directories, in the current directory|

## Clone & Status
To clone a repository on our local machine
```bash
git clone <some link>
```
To display the status of the code
```bash
git status
```
untracked - new files that git doesn't yet track<br>
modified - changed<br>
staged - file is ready to be committed<br>
unmodified - unchanged<br>

## Add & Commit
To add new or changed files in your working directory to the Git staging area
```bash
git add <-file name->
```
To record the changes or commit the changes
```bash
git commit -m "some message"
```   
## Push Command
To upload local repo content to remote repo
```bash
git push origin main
```
The above command is used to push the local changes in the "main" branch to the remote repository named "origin." 
To create the shorthand for 'git push '. We set the shorthand by
```bash
git push -u origin main
```
The -u flag is short for '--set-upstream' , and it is used to set the upstream branch for the local branch. This means that in the future, you can simply use 'git push' without specifying the branch and Git will push to the branch you set as upstream.
