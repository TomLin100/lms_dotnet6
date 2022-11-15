#!/bin/zsh


if [ -z $1 -a -z $2 ];then
    echo "請輸入參數！！"
    exit
fi

dotnet user-secrets set LMSweb "Server=localhost;Database=LMSmodel;User ID=$1;Password=$2;Encrypt=False"
dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.10
dotnet add package Microsoft.EntityFrameworkCore.Tools -v 6.0.10
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 6.0.10
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 6.0.10