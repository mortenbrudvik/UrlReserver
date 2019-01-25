# UrlReserver

Wrapper class for netsh http to support reserving an url from code. 

Usage example: Wix - Custom action to reserve an url on application install.


## NetSh Support

Reserve url
````
netsh http add urlacl url=<address> user=<user>
````

Un-reserve url
````
netsh http delete urlacl url=<address>
````

