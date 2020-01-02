# SpeedTest.Net
A simple https://speedtest.net client to calculate download speed in KB/s. Made with love using .Net Core.

#### Get a Server closest to your location
```
var server = await SpeedTestClient.GetServer();
```


#### Or Get a Server closest to the provided geo co-ordinates
```
var server = await SpeedTestClient.GetServer(37.0902, 95.7129);
```


#### Get Download Speed using the server
```
var speed = await SpeedTestClient.GetDownloadSpeed(server);
```


#### Or simply Get Download Speed using your location
```
var speed = await SpeedTestClient.GetDownloadSpeed();
```
