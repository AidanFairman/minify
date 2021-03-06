FROM gitpod/workspace-mysql

# Install custom tools, runtimes, etc.
# For example "bastet", a command-line tetris clone:
# RUN brew install bastet
#
# More information: https://www.gitpod.io/docs/config-docker/
RUN apt-get update;
RUN apt-get install -y apt-transport-https && apt-get update && apt-get install -y dotnet-sdk-5.0
