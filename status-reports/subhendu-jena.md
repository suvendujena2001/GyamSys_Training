
# Progress Report - Subhendu Jena

## Week 1

### MarkDown
  - Researched about the ***MarkDown*** and learned the ***basic syntax***.
  - Understood the ***uses and working*** of Markdown Language.
  - Started ***documenting*** the work progress using the MarkDown language.

### Git and GitHub
  - What is Version Control System and Git?
  - What is GitHub and uses?
  - Explored the GitHub platform. 
  - Differnece between Git and GitHub.
  - The terminologies associated with Git.
  - Using Git from the Command Line and an IDE (VS Code).
  - Learned the different Git commands.
      - Getting a Git Repo
        - git clone <-some link->  (https link of the repo from github to be cloned)
      - SnapSotting the changes
        - status of the Git file (untracked, modified, staged, unmodified)
          - git status
        - keep track of the progress of a Git file (stage and record a change)
          - git add <-file name->
          - git commit -m "some message"
      - Share and Update the Git file location (upload or download)
        - local to remote location
          - git push origin main
        - remote to local location
          - git pull origin main
      - Create a new Git Repo
          - git init
          - git remote add origin <-link->
          - git remote -v (to verify remote)
      - Branching and merging
          - Branching commands
            - git branch (to check branch)
            - git branch -M main (to rename a branch)
            - git checkout -b <-new branch name-> (create a new branch)  
            - git checkout (to navigate branch)
            - git branch -d <-branch name -> (to delete a branch)
          - Merging command
            - git diff <-branch name-> (to compare commits, branches, files and more)
            - git merge <-branch name-> (to merge 2 branches)
            - Creating a Pull Request from a GitHub
      - Undoing changes in Git
          - Staged changes
             - git reset <-file name->
             - git reset .
          - committed changes (for a single commit)
             - git reset HEAD~1
          - committed changes (for multiple commits)
             - git reset <-commit hash->
             - git reset --hard <-commit hash->
          - git log (displays all the log activity on the Git
  - Understood how to resolve conflicts during merge operations.

### HTML and CSS
   - Revised the basics of HTML and the syntax.
   - Revised the HTML elements and attributes tags.
   - Styling within HTML.
   - Revised the basics of CSS and the syntax.
   - External CSS, Internal CSS and Inline CSS
   - Revised styling using CSS.
   - Went through advanced CSS and Flexbox concepts.
