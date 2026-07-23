# Exercise 3 - Remotes, Forking, and Pull Requests

This exercise requires a free GitHub account.

## Part A - Remote basics
```bash
# From your git-lab folder created in Exercise 1
# Create an empty repo on GitHub named "git-lab" first, then:
git remote add origin https://github.com/<your-username>/git-lab.git
git remote -v
git push -u origin main
```

## Part B - Fork and pull request workflow
1. On GitHub, fork the Digital Nurture DotNet FSE exercises repository
   referenced in the handbook's Exercise Instructions section.
2. Clone **your fork** locally:
   ```bash
   git clone https://github.com/<your-username>/Digital-Nurture-DotNetFSE.git
   cd Digital-Nurture-DotNetFSE
   git remote add upstream https://github.com/seshadrimr/Digital-Nurture-DotNetFSE.git
   ```
3. Create a branch for your solution, commit your hands-on work, and push
   it to your fork:
   ```bash
   git checkout -b week1-solutions
   # ... add your solution files ...
   git add .
   git commit -m "Week 1 hands-on solutions"
   git push -u origin week1-solutions
   ```
4. Open a Pull Request from `week1-solutions` on your fork into your own
   `main` branch (since you won't have write access to upstream) - this
   simulates the real PR review workflow your team will use.
5. Practice keeping your fork up to date:
   ```bash
   git fetch upstream
   git checkout main
   git merge upstream/main
   git push origin main
   ```

## Questions to answer
1. What is the difference between `origin` and `upstream` in a fork-based
   workflow?
2. Why does a forking workflow (rather than direct branches on one shared
   repo) make sense for open-source or large-team contributions?
3. What should a good Pull Request description include?
