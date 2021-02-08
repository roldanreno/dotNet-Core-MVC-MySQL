# Creating a MVC application using .Net Core and Amazon RDS MySQL

In this tutorial you will create a web application and a MySQL database using AWS

## Creating the project

1. Open a terminal and create an dotnet core project using the MVC template.

2. Algo

## Deploying

1. Deploy a Amazon EC2 Instance with Graviton2

2. Download and build a recent version of International Components for Unicode. Amazon Linux 2 recently added libicu60 to the package manager, so you can simply install it with yum

    ```ssh
    sudo yum -y install libicu60
    ```

3. Follow the instructions from Microsoft to install the dotnet sdk. Download the dotnet sdk from the Microsoft Website

    ```ssh
    cd ~
    wget https://download.visualstudio.microsoft.com/download/pr/5ee48114-19bf-4a28-89b6-37cab15ec3f2/f5d1f54ca93ceb8be7d8e37029c8e0f2/dotnet-sdk-3.1.302-linux-arm64.tar.gz
    mkdir -p $HOME/dotnet && tar zxf ~/dotnet-sdk-3.1.302-linux-arm64.tar.gz -C $HOME/dotnet
    export DOTNET_ROOT=$HOME/dotnet
    export PATH=$PATH:$HOME/dotnet
    ```

4. Testing it...If you see the following dotnet is installed

    ```ssh
    dotnet

    Usage: dotnet [options]
    Usage: dotnet [path-to-application]

    Options:
    -h|--help         Display help.
    --info            Display .NET Core information.
    --list-sdks       Display the installed SDKs.
    --list-runtimes   Display the installed runtimes.

    path-to-application:
    The path to an application .dll file to execute.

    dotnet --list-sdks
    3.1.302 [/home/ec2-user/dotnet/sdk]
    ```
