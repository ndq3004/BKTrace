#!/bin/bash
sudo docker build -t front-end-vue . && 
sudo docker images | grep font-end-vue
