#!/bin/bash
set -ev
eval $(aws ecr get-login --region ap-southeast-2 --no-include-email)
docker-compose build
docker tag studentapi/web:latest 599080142044.dkr.ecr.ap-southeast-2.amazonaws.com/studentapi/web:latest
docker push 599080142044.dkr.ecr.ap-southeast-2.amazonaws.com/studentapi/web:latest