import socket

    
port = 5050
ServerName = '192.168.1.39'

clientSocket = socket.socket(socket.AF_INET,socket.SOCK_STREAM)
clientSocket.connect((ServerName, port))
while True:
    str = input("\n[Client] Enter a string to be reversed: ")
    clientSocket.send(str.encode())
    print(f"\n[Client] From Server: {clientSocket.recv(2048).decode()}")
    if str.lower() == 'end':
        break;
print("\n[Client] Shutting Down")




