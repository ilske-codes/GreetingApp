# Greeting App

The Greeting App is a super basic API serving as an example implementation of a dockerised API and the associated deployment and CI/CD pipeline configuration.

## Running locally
To build and run the docker container you will need to have docker desktop installed (https://www.docker.com/products/docker-desktop/).

### Build the container
To build the container you can either use Visual Studio or the command line.

#### Visual Studio
```
Right-click on the Dockerfile and selecting "Build Docker Image"
```

#### Command line
Run the following command from the solution folder:
```
docker build -t greetingapp --file .\GreetingApp\Dockerfile .
```

### Run the container
For running locally we assume that you are using docker desktop. Using a command window, navigate to the root folder of the solution (where the compose.yaml file sits) and run the following command:

```
docker compose up
```
You should now be able to navigate to the API on http://localhost:56724. If you need to adjust the port number, you will have to modify this in the compose.yaml file.

## Running tests




## Steps to trigger the CI/CD pipeline




## TO DO
- Ask a colleague who uses a Mac to add to these instructions where necessary
