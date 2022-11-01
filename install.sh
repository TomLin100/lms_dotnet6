#!/bin/zsh

if [ -z $1 -a -z $2 ];then
    echo "請輸入參數！！"
    exit
fi

dotnet tool install -g dotnet-ef
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
dotnet user-secrets set LMSweb "Server=localhost;Database=LMSmodel;User ID=$1;Password=$2"
git clone https://github.com/zsh-users/zsh-syntax-highlighting.git ${ZSH_CUSTOM:-~/.oh-my-zsh/custom}/plugins/zsh-syntax-highlighting