# Notes for the reviewers
Hi, I just wanted to add some notes to my submitted work.

My CI/CD pipeline implementation is incomplete, firstly because I haven't used GitHub Actions before so there was a lot of learning to do for a 4 hour assignment and secondly because I didn't want to risk getting a hefty AWS or Azure bill.

The features I was hoping to add but are not included:
- Running the postman collection tests against a running instance of the container after building the container image
- Pushing the container image to some sort of repository
- Seeing if I could break out the deployment in a separate workflow and trigger that workflow after the building and testing of the container image had completed (I was thinking that I should be able to (re)deploy the exact same container image to the same or another environment rather than always building one) 


