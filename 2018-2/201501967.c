#define __USE_GNU
#define _GNU_SOURCE
#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <time.h>
#include <fcntl.h>
#include <stdlib.h>
#include <string.h>

const char *lock_file = "/tmp/LCK.test";
void countfile(int n);
int count = 0;
//lock file

int main(int argc, char *argv[])
{
	struct tm *tm_ptr;
	int filedes, lock;

	time_t start_time;
	time_t end_time;

	char buffer[50];
	char co[50];
	pid_t pid;
	int i=0;

	(void)time(&start_time);
	tm_ptr = gmtime(&start_time);
	sprintf(buffer, "countLog.%d.%d.%d", tm_ptr->tm_year+1900, tm_ptr->tm_mon+1, tm_ptr->tm_mday);//year print 2018 - 1900 so + 1900 and month start with 0 so +1
	//countLog time

	filedes = open(buffer, O_CREAT | O_RDONLY, 0644);
	close(filedes);

	//gamer
	if(strcmp(argv[1], "-p")==0)
	{
		//argument = 1
		if(strcmp(argv[2], "1")==0)
		{
			
			countfile(2);
		}	
		//argument = 2
		else if(strcmp(argv[2], "2")==0)
		{	
			pid=fork();
			//player a
			if(pid==0)//child process
			{
				countfile(0);
			}
			//player b
			else if(pid>0)//parent process
			{
				countfile(1);
			}
			else
			{
				printf("Error!");
				exit(0);
			}	
			
		}			
		else
			printf("error!\n");
	}
	else
		printf("arguments Error!\n");

	
	exit(0);
}
void countfile(int n)
{
	while(count<=100)//when game goes 100 times, go to sleep
	{	
		sleep(n);
		count++;
		if(count%10 == 0)
		{
			while(1)
			{
				lock = open(lock_file, O_RDWR | O_CREAT | O_EXCL, 0444);//open lock file
				if(lock==-1)
					continue;
				else
					break;
			}
			filedes = open(buffer, O_RDWR | O_APPEND);

			(void)time(&start_time);
			tm_ptr = gmtime(&start_time);
			printf("Gate %d : %d\n",getpid(),count);
			sprintf(co, "Gate %d - %d분 %d초 : %d\n",getpid(), tm_ptr->tm_min, tm_ptr->tm_sec, count);
			write(filedes, co, strlen(co));

			//kill it
			(void)close(filedes);	
			(void)unlink(lock_file);
		}
					
	}
}


