#!/bin/sh

# Installs yeoman and aspnet generator 
# Fixes installation of ASP.NET 5.0 1.0.0-rc1-final on MacOS 
# Assumes ASP.NET has been installed with binary installer

npm install -g yo bower grunt-cli gulp
npm install -g generator-aspnet
rmdir ~/.dnx/runtimes
sudo ln -s /usr/local/lib/dnx/runtimes ~/.dnx/
dnvm upgrade