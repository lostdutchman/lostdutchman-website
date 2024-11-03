FROM python:3.8-slim
LABEL maintainer="lostdutchmansoftware@gmail.com"

# Copy requirements.txt and install dependencies
COPY requirements.txt requirements.txt
RUN pip3 install -r requirements.txt

# Set the working directory in the container
COPY website /website
WORKDIR /website

# Expose the port the Flask app will run on
EXPOSE 5000

# Run the Flask app
CMD ["python", "tcm.py"]