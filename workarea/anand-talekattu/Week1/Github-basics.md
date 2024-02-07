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
git clone <remote repo url>
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
git push origin <-branch name->
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
To create a new branch
```bash
git branch <new_branch_name>
```
To rename branch
```bash
git branch -M new_name
```
To navigate to specific branch
```bash
git checkout <- branch name ->
```
To create a new branch and navigate to it
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
git diff <- branch name with which we want to compare ->
```
To merge 2 branches
```bash
git merge <- branch name ->
```
### Way2(using github)
Create a Pull Request.<br>
A pull request in GitHub is a way to propose changes to a repository. It allows you to submit changes that you've made in a branch of your repository to be reviewed by others and merged into the main branch.
- Go to the GitHub repository.
- Switch to the `target-branch` using the branch selector.
- Click on the "compare and pull request" or "New pull request" button.
- In the "base" dropdown, select the `target-branch`.
- In the "compare" dropdown, select `source-branch`.
- Click "Create pull request."
- Discuss the changes with your team and if uyou have any comments.
- If everything looks good, merge the pull request using "Merge pull request".
- Then click "confirm merge" which will add new commit about the merge.

## Pull Command
To update your local branch with changes made by others on the remote repository.
```bash
git pull origin target-branch
```
The command `git pull origin target-branch` is used to fetch changes from the remote repository (`origin`) and merge them into the currently checked-out branch (`target-branch`). 

## Resolving Merge conflicts
Resolving merge conflicts in Git occurs when there are conflicting changes in different branches, and Git cannot automatically merge them. We can resolve merge conflicts as follows:

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
One of the common undos takes place when you commit too early and possibly forget to add some files, or you mess up your commit message. If you want to redo that commit, make the additional changes you forgot, stage them, and commit again using the `--amend` option:
```bash
git commit --amend
```
This command takes your staging area and uses it for the commit. If you’ve made no changes since your last commit (for instance, you run this command immediately after your previous commit), then your snapshot will look exactly the same, and all you’ll change is your commit message.

The same commit-message editor fires up, but it already contains the message of your previous commit. You can edit the message the same as always, but it overwrites your previous commit.
As an example, if you commit and then realize you forgot to stage the changes in a file you wanted to add to this commit, you can do something like this:
```bash
git commit -m 'Initial commit'
git add forgotten_file
git commit --amend
```
You end up with a single commit — the second commit replaces the results of the first.

Case1: staged changes
```bash
git reset <- file name ->
git reset 
```
Case2: committed changes(for one commit)
```bash
git reset HEAD~1
```
Case3: committed changes(for many commits)
```bash
git reset <- commit hash ->
```
```bash
git reset --soft <-commit hash ->
```
- This option moves the HEAD to the specified commit without altering the index or the working directory.
- It's useful when you want to undo the last commit but keep the changes staged. After the soft reset, the changes from the undonne commit will appear as staged changes, ready to be committed again.
```bash
git reset --mixed <-commit hash ->
```
- This is the default behavior if no option is specified. It resets the HEAD to the specified commit and updates the index (staging area) to match, but it does not alter the working directory.
- This is useful when you want to undo the last commit and unstage its changes, so they appear as unstaged changes in the working directory. You can then selectively stage and commit the changes.
```bash
git reset --hard <-commit hash ->
```
- This option resets the HEAD to the specified commit, updates the index to match, and resets the working directory to match the state of the commit.
- If effectively discards all changes made after the specified commit.
- This is useful when you want to completely discard all changes made after a certain commit and return to this state. However, it's also the riskiest options because it can cause loss of uncommitted changes.

You can get the hash by executing (to check commit history)
```bash
git log
```

## Viewing the Commit History
After you have created several commits, or if you have cloned a repository with an existing commit history, you’ll probably want to look back to see what has happened. The most basic and powerful tool to do this is the `git log` command.
```bash
git log
```
By default, with no arguments, git log lists the commits made in that repository in reverse chronological order; that is, the most recent commits show up first. 

- One of the more helpful options is `-p` or `--patch`, which shows the difference (the patch output) introduced in each commit. You can also limit the number of log entries displayed, such as using `-2` to show only the last two entries.
  ```bash
  git log -p -2
  ```
  This option displays the same information but with a diff directly following each entry. This is very helpful for code review or to quickly browse what happened during a series of commits that a collaborator has added.

- You can also use a series of summarizing options with git log. For example, if you want to see some abbreviated stats for each commit, you can use the `--stat` option:
  ```bash
  git log --stat
  ```
  The `--stat` option prints below each commit entry a list of modified files, how many files were changed, and how many lines in those files were added and removed. It also puts a summary of the information at the end.

- Limiting Log Output<br>
  The time-limiting options such as --since and --until are very useful. For example, this command gets the list of commits made in the last two weeks:
  ```bash
  git log --since=2.weeks
  ```
  This command works with lots of formats — you can specify a specific date like "2008-01-15", or a relative date such as "2 years 1 day 3 minutes ago".

## Fork
A fork is a new repository that shares code and visibility settings with the original "ustream" repository.<br>
Fork is a rough copy
