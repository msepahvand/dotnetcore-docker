#!/bin/bash
set -ev

docker-compose build
docker tag org/web:latest 599080142044.dkr.ecr.ap-southeast-2.amazonaws.com/org/web:latest
docker push 599080142044.dkr.ecr.ap-southeast-2.amazonaws.com/org/web:latest