## My first Documentation using Markdown language

#Understanding Github Platform
## The need of Github
- Developer needs a web/cloud based code hosting platform
- Useful for version control
- Enables effective collaboration
- Download projects and files in one go
- Easy evaluation of each other works
## What is repository?
  - Repository is a place where you create a file afor your project. It is basically a storage
#Git
## What is Git?
- git is a popular version control system. It is used for 
    1. checking code changes
    2. checking who made changes
    3. coding collaboration
##What does git do?
- Manage projects with repositories
- clone a project to work on a local copy
- control and track changes with Staging and committing
- branch and Merge to allow for work on different parts and version of a project
- pull the latest version of the project to a local copy
- Push local updates to the main project
##Git Commands
1. **git ---version:** use to check the version of the git installed in th esystem
2. **git config --global user.name "name"**
            and
   **git config --global user.email "emailid":** let git know who you are. Each commit uses this information.
3. **git init:** Once you have navigated to the correct folder, you can initialize Git on that folder.
4. **ls:** It will list the files in the directory.
5. **git status:** To check if the file is a part of the repository.
   Files in folder can be two types 
   1. **track files** that get nose about and are added to repository
   2. **untracked files** that are in the working directory but not added to the repository
6. **git add "filename":** to add a file in the stagging environment.
7. **git add -A:** To add all the files in the stagging environment
8. **git commit -m "message":** It performs a commit operation  and [-m "message"] add a comment.
9. **git remote add origin https: //[USER_TOKEN]@github.com/repository_name/file_name.git:**
- **git remote add origin:** This command is used to add a remote named "origin" to your Git configuration.
- **https://[USER_TOKEN]@github.com/repository_name/file_name.git:** This is the URL of the Git repository. You should replace [USER_TOKEN] with your actual GitHub token (or password), repository_name with the name of your repository, and file_name with the specific path or filename you want.
10. **git push origin main:** This process ensures that you have the latest changes from the remote repository and that your local changes are integrated properly.
11. **git push -f origin main:** If you're the only person working on this repository and are sure that your local changes should overwrite the remote ones, you can force push.
12. **git log:** To view the history of commits.

#END