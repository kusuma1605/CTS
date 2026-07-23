# Exercise 2 - Branching, Merging, and Resolving a Conflict

Continue in the `git-lab` repo from Exercise 1.

```bash
# 1. Create and switch to a feature branch
git branch feature/discount
git checkout feature/discount
# (or in one step: git checkout -b feature/discount)

echo "function applyDiscount(price) { return price * 0.9; }" >> app.js
git add app.js
git commit -m "Add discount function"

# 2. Meanwhile, someone else changes main
git checkout main
echo "console.log('hello world'); // updated on main" > app.js
git add app.js
git commit -m "Tweak greeting on main"

# 3. Merge the feature branch back into main - this WILL conflict
git merge feature/discount
```

You should see a conflict in `app.js`. Open the file - Git will have
inserted conflict markers (`<<<<<<<`, `=======`, `>>>>>>>`). Manually edit
the file to keep both changes, then:

```bash
git add app.js
git commit -m "Merge feature/discount into main, resolve conflict"
git log --oneline --graph --all
```

## Branching strategy practice

Simulate a simplified Git Flow:

```bash
git checkout -b develop main
git checkout -b feature/loyalty-points develop
echo "function loyaltyPoints(total) { return Math.floor(total / 10); }" >> app.js
git add app.js
git commit -m "Add loyalty points calculation"
git checkout develop
git merge feature/loyalty-points --no-ff -m "Merge loyalty points feature"
git checkout main
git merge develop --no-ff -m "Release: loyalty points"
```

## Questions to answer
1. What triggered the merge conflict, specifically?
2. What does `--no-ff` do, and why might a team require it for feature
   branches merging into `develop` or `main`?
3. When would you choose `git merge` vs. `git rebase` for bringing a
   feature branch up to date with `main`?
