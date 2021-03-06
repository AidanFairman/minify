FROM gitpod/workspace-mysql

RUN cat /etc/os-release;

RUN wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb

RUN sudo dpkg -i packages-microsoft-prod.deb

RUN sudo apt-get update;

RUN sudo apt-get install -y apt-transport-https && sudo apt-get update && sudo apt-get install -y dotnet-sdk-5.0
