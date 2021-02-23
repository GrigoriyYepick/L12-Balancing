# L12-Balancing
 
### Build:
```
docker-compose build

docker-compose up -d
```

Resuls below were taken from ![access.log](https://github.com/GrigoriyYepick/L12-Balancing/blob/main/nginx/access.log).

Request to localhost from the same machine<br>
Response: 200 "Hello from default server"

Request from UK IP via VPN and NGrok<br>
Response: 200 "Hello from UK server"

Request from US IP via VPN and NGrok<br>
Response: 200 "Hello from US1 server"

Request from US IP via VPN and NGrok<br>
Response: 200 "Hello from US2 server"

### Changed reposnse of UK server to 404<br>
### Nginx Reload

Request from UK IP via VPN and NGrok<br>
Response: 404 "Error"

### Removed UK server from nginx.conf<br>
### Nginx Reload

Request from UK IP via VPN and NGrok<br>
Response: 200 "Hello from backup UK server"
