#include <stdio.h>
#include <sys/ptrace.h>
#include <sys/types.h>
#include <sys/wait.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <netdb.h>


int main(int argc, char *argv[])
{
  int port, sockfd;
  struct hostent *server;
  struct sockaddr_in serv_addr;
  char buf[256];
  int size;
  char *ret;
  
  if (argc < 3)
  {
    fprintf(stderr, "usage is %s hostname port", argv[0]);
    return 1;
  }
  
  port = atoi(argv[2]);
  server = gethostbyname(argv[1]);
  if (server == NULL)
  {
    fprintf(stderr, "no such host", argv[0]);
    return 1;
  }
  
  sockfd = socket(AF_INET, SOCK_STREAM, 0);
  bzero((char *) &serv_addr, sizeof(serv_addr));
  serv_addr.sin_family = AF_INET;
  bcopy((char *)server->h_addr,
        (char *)&serv_addr.sin_addr.s_addr,
        server->h_length);
  serv_addr.sin_port = htons(port);
  
  if (connect(sockfd,&serv_addr,sizeof(serv_addr)) < 0)
  {
    fprintf(stderr, "error connecting", argv[0]);
    return 1;
  }
  
  while (!feof(stdin) && !ferror(stdin))
  {
    size = fread(buf, 1, sizeof(buf), stdin);
    send(sockfd, buf, size, 0);
    fwrite(buf, 1, size, stdout);
    if (size < sizeof(buf))
      break;
  }
  
  shutdown(sockfd, SHUT_RDWR);
  close(sockfd);
  
  return 0;
}
