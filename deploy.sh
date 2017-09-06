#!/bin/bash
set -ev
eval $(aws ecr get-login --region ap-southeast-2)
docker-compose build
docker tag org/web:latest 599080142044.dkr.ecr.ap-southeast-2.amazonaws.com/org/web:latest
docker push 599080142044.dkr.ecr.ap-southeast-2.amazonaws.com/org/web:latest