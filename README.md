# Signup Course

This is an Application that intends to improve the SignUp process to a Course.
It was built to create SignUp for courses and provide some Statistics about it.
The intention was to provide a way to process multiple signup requests avoiding to exceed the total vacancies of the course.

## Architectural overview
I'm gonna list all patterns and tools I have used in this solution:
- DDD
- CQRS
- Mediator Pattern
- Message Bus
- Repository Pattern
- 
- In order to achieve a better efficiency I decided to use a message queue to save all signup requests. But for now I have used a library called MediatR to simulate the process to save in a queue and workers that will read from it. But it will be refectored using (RabbigMQ, kafka or any other message bus);
- To let the code cleaner and isolate queries from commands that make some kind of changes to an entity I decided to use CQRS Pattern, and of course I'm using MediaTr library to make things work;
- I have also used Domain Driven Design to enrich the domain modeling;

## Test strategy for this solution
- All the components was build with the power of Dependency injection, in which the components depends on abstractions than the concrete structure;
- I created an Unit Test Project using xUnit called "CourseSignUp.UnitTests". In this one I can test most of the components of "CourseSignUp.Application" and "CourseSignUp.Domain" layers;
- I also created an Integration Test project using xUnit with the intention to test "CourseSignUp.API" layer;
- I have not created the Test Projects, but as I mentioned earlier It will be easy to do because the development was well designed to isolate the responsibilities of each layer (Of course there is always something to improve, but from now it's Ok);

## Tools and technologies
- MediaTR;
- Moq;
- xUnit
- For storage I end up simulating a fake persistency using static list but I will replace to some relational database using EntityFrameWork;
- I also simulate cache mechanism, but I will replace using Redis or MongoDb to update Statistics after the signup process and make queries faster;
(libraries, framework, tools, storage types, cloud platform features)

## What it can be improved and how?
- I need to create a lock mechanism in order to prevent signup request to exceed the total vacancies of the course. Using a robust Message broker will improve the performance making asynchronous processing. And I also have created a business validation to avoid exceeds the total vacancies but I know I need to mitigate the risk of parallel tasks. I need to think more about it;

## Final considerations
- I did my best in the least time I had.
