docker build -t web:latest -f src/Web/Dockerfile .
docker save web:latest -o _images/poskeepering-latest.tar
read -n 1 -s -r -p "Press any key to continue"