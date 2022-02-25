import threading
import socket

#Function to reverse input string
def reverseString(string):
    reversedString = ""
    for c in string:
        reversedString = c + reversedString
    return reversedString

#Create and bind Server Socket
serverSocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
serverSocket.bind(("",5050))
print("[Server] READY")


#Loop for getting client input
serverSocket.listen()
print(f"\n[Server] Listening on: localhost")
connectedSocket, addr = serverSocket.accept()
while True:
    #Client connected get input and return it
    print(f"\n[Server] New Connection {addr} connected.")
    input = connectedSocket.recv(2048).decode()
    print("\n[Server] input is: " + input)

    #Check input returning reverse string or dne
    connectedSocket.send(reverseString(input).encode())
    if input == "end":
        break;


serverSocket.close()
print('\n[Server] Shutting Down')





