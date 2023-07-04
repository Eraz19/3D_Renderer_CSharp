# Setup project

This project is using c# (dotnet 6.0.118) on vscode and the SDL2 all on a linux machine.

## Install dotnet

To install dotnet on a linux distro follow this tutorial:
https://tecadmin.net/how-to-install-dotnet-core-on-ubuntu-22-04/

## Install SDL2 for C#

To install SDL2 on your machine:
```shell
➜  ~ sudo apt install libsdl2-dev
```

For more information https://wiki.libsdl.org/SDL2/Installation.

The installed SDL2 is a C library but we need the C# library so let's download a C# binding at https://github.com/flibitijibibo/SDL2-CS.

Let's clone the code in our project and put the code in a folder called ```lib```.

```shell
➜  ~ mkdir lib
➜  ~ cd lib
➜  ~ clone https://github.com/flibitijibibo/SDL2-CS.git # The HTTPS URL of the code at the time
```

If we try to run some code the compiler will give us some error about some unsafe code being used.

To remove this error lets go to the ```.csproj``` file and let's add a line to autorize this unsafe code.

```cs
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
    <RootNamespace>_3DRenderer</RootNamespace> // specific to the project name
	<AllowUnsafeBlocks>true</AllowUnsafeBlocks> // line to add to autorize unsafe code 
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```
## Init GIT project

To save the progress of the project lets initialize a git repository.

project structure:
```shell
.
├── 3DRenderer.csproj
├── bin
├── lib
│   └── SDL2-CS # SDL2 C# binding
├── obj
├── Program.cs # program entry point
└── src # create this folder to put all our code
```

.gitignore
```shell
# The content of these folder will be ignored when added to the git repo
lib/
bin/
obj/
```

Lets initialize our git repo. First go to your git 

```shell
➜  ~ git init # initialize the git repo
➜  ~ git add --all # adds all the folder to the list of commits
➜  ~ git commit -m "First commit to initialize project repo"
```
