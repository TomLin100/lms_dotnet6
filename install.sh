#!/bin/zsh

cp zshrc.txt ~
mv ~/zshrc.txt ~/.zshrc

dotnet tool install -g dotnet-ef
dotnet tool install -g Microsoft.Web.LibraryManager.Cli

git clone https://github.com/zsh-users/zsh-syntax-highlighting.git ${ZSH_CUSTOM:-~/.oh-my-zsh/custom}/plugins/zsh-syntax-highlighting

source ~/.zshrc