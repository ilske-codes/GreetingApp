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
The example solution includes both unit tests and integration tests

### Unit tests
The unit tests can be run from Visual Studio or from the command line and are automatically run in the pipeline before creating the container image.

### Integration tests
Two different variations of integration tests are included:
- In de solution there are integration tests included that use the in process hosting of the API to run the endpoint tests
- The Postman collection can be used to run endpoint tests against a locally running container. 

## CI/CD pipeline

The CI/CD pipeline for this example is implemented using GitHub Actions

### Running the pipeline locally
To run the GitHub Actions pipeline locally you will need to have **act** installed (see https://nektosact.com/ for installation and usage instructions)

### Locating and triggering the pipeline in the repo
The pipeline is defined to trigger on a push to the main branch (see main.yml in the .github\workflows folder for the definition). The execution details can be found under the Actions tab in the GitHub repo.


## TO DO
- Ask a colleague who uses a Mac to add to these instructions where necessary
- Add the running of the Postman tests to the CI/CD pipeline
- Add the publish of the container image to the CI/CD pipeline
- Add the deployment step to the CI/CD pipeline
