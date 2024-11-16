set LANG=ja_JP.UTF-8
git config --global core.quotepath false

git add .
printf "\n"

git status
printf "\n"

#read -p "Commit."

git commit -a -m'Update'
printf "\n"

#read -p "Sync."

git pull -v --progress "origin"
<<<<<<< HEAD
#printf "\n"

git push -v --progress "origin" main:main
#printf "\n"
=======
printf "\n"

git push -v --progress "origin" main:main
printf "\n"
>>>>>>> 12bce315bbbe299a380e4d708fdbeb6c8f8b2fa0

#read -p "Complete."
