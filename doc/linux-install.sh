#!/bin/sh

sudo apt-get update

sudo apt-get install libunwind8 libssl-dev unzip
sudo apt-get install mono-devel
mozroots --import --sync
curl -sSL https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.sh | DNX_BRANCH=dev sh && source ~/.dnx/dnvm/dnvm.sh
source /home/azureuser/.dnx/dnvm/dnvm.sh
dnvm upgrade

sudo apt-get install make automake libtool
curl -sSL https://github.com/libuv/libuv/archive/v1.4.2.tar.gz | sudo tar zxfv - -C /usr/local/src
cd /usr/local/src/libuv-1.4.2
sudo sh autogen.sh
sudo ./configure
sudo make
sudo make install
sudo rm -rf /usr/local/src/libuv-1.4.2 && cd ~/
sudo ldconfig

sudo apt-get install git

sudo service unscd stop

sudo apt-get install nginx