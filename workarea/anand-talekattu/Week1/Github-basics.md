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

## Git initialization
To initialize a new git repo
```bash
git init
```
After running `git init`, your directory will now contain a hidden subfolder named `.git`. This folder is where Git stores the internal data structure and configuration files for your repository.

To upload our local repo to github repo
```bash
git remote add origin <-github repo link->
```
To verify remote
```bash
git remote -v
```
## Branch commands
To check branch
```bash
git branch
```
To rename branch
```bash
git branch -M new_name
```
To navigate to specific branch
```bash
git checkout <- branch name ->
```
To create a new branch
```bash
git checkout -b <- new branch name ->
```
To delete a branch we should navigate to other branch and execute
```bash
git branch -d <- branch name ->
```

## Merging Code
### Way1
To compare commits, branches, files & more
```bash
git diff <- branch name ->
```
To merge 2 branches
```bash
git merge <- branch name ->
```
### Way2
Create a Pull Request
A pull request in GitHub is a way to propose changes to a repository. It allows you to submit changes that you've made in a branch of your repository to be reviewed by others and merged into the main branch.
- Go to the GitHub repository.
- Switch to the `target-branch` using the branch selector.
- Click on the "New pull request" button.
- In the "base" dropdown, select the `target-branch`.
- In the "compare" dropdown, select `source-branch`.
- Click "Create pull request."
- Discuss the changes with your team.
- If everything looks good, merge the pull request.

## Pull Command
To update your local branch with changes made by others on the remote repository.
```bash
git pull origin target-branch
```
The command `git pull origin target-branch` is used to fetch changes from the remote repository (`origin`) and merge them into the currently checked-out branch (`target-branch`). 

## Resolving Merge conflicts
Resolving merge conflicts in Git occurs when there are conflicting changes in different branches, and Git cannot automatically merge them. Here's a step-by-step guide on how to resolve merge conflicts:

- Start a Merge:<br>
  Start the merge process using a command like `git pull` or `git merge`. If conflicts are encountered, Git will stop and mark the conflicted files.
```bash
git pull origin target-branch
```
- Conflicts Detected:<br>
If there are conflicts, Git will notify you. You'll see a message similar to:<br>
<pre>
Auto-merging path/to/conflicted/file
CONFLICT (content): Merge conflict in path/to/conflicted/file</pre>
Git will also mark the conflicted sections in the file. Open the conflicted file(s) in your code editor.

- Manually Resolve Conflicts:<br>
Inside the conflicted file, Git will mark the conflicting sections with `<<<<<<<`, `=======`, and `>>>>>>>` markers. Edit the file to resolve the conflicts manually.<br>
For example:
<pre><<<<<<< HEAD
This is the content from the current branch (HEAD).
=======
This is the content from the incoming branch (target-branch).
>>>>>>> target-branch</pre>
Choose which changes to keep, or merge the changes manually. Remove the conflict markers and unnecessary lines.

- Save the Changes:<br>
Save the changes to the conflicted file after resolving the conflicts.
- Add and Commit:<br>
After resolving conflicts, stage the changes and commit them.
<pre>git add path/to/conflicted/file
git commit -m "Resolve merge conflicts in path/to/conflicted/file"
</pre>

- Continue the Merge:<br>
If you were in the middle of a merge, continue the merge process:
<pre>git merge --continue
</pre>
If you were pulling changes, Git might automatically continue the merge after you've resolved conflicts.

## Undoing Changes
Case1: staged changes
```bash
git reset <- file name ->
```
Case2: committed changes(for one commit)
```bash
git reset HEAD~1
```
Case3: committed changes(for many commits)
```bash
git reset <- commit hash ->
git reset --hard <-commit hash ->
```
You can get the hash by executing 
```bash
git log
```

## Fork
A fork is a new repository that shares code and visibility settings with the original "ustream" repository.<br>
Fork is a rough copy
