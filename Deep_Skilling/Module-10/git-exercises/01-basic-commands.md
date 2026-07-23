# Exercise 1 - Basic Git Commands

Run these commands in order in an empty folder and observe the output at
each step. Take a screenshot or note down what `git status` shows after
every command - you'll need it for self-evaluation.

```bash
# 1. Initialize a repo
mkdir git-lab && cd git-lab
git init
git config user.name "Your Name"
git config user.email "you@example.com"

# 2. First commit
echo "# Git Lab" > README.md
git status
git add README.md
git status
git commit -m "Initial commit"
git log --oneline

# 3. Track changes
echo "console.log('hello');" > app.js
git add .
git commit -m "Add app.js"

# 4. Modify and diff
echo "console.log('hello world');" > app.js
git diff
git add app.js
git commit -m "Update greeting"

# 5. Inspect history
git log --oneline --graph --all
```

## Questions to answer
1. What is the difference between the working directory, the staging area,
   and the repository?
2. What does `git diff` show *before* `git add`, versus `git diff --staged`
   *after* `git add`?
3. Why does `git commit` fail if nothing has been staged?
