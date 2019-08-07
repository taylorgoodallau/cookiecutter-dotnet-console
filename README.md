# Cookiecutter for Dotnet Console Applications 

A Cookiecutter template to create Dotnet Console Applications

> It is important to note that you should not try to `git clone` this project but use `cookiecutter` CLI instead as ``{{cookiecutter.project_slug}}`` will be rendered based on your input and therefore all variables and files will be rendered properly.

## Requirements

Install `cookiecutter` command line: 

**Pip users**:

* `pip install cookiecutter`

**Homebrew users**:

* `brew install cookiecutter`

**Windows or Pipenv users**:

* `pipenv install cookiecutter`

**NOTE**: [`Pipenv`](https://github.com/pypa/pipenv) is the new and recommended Python packaging tool that works across multiple platforms and makes Windows a first-class citizen.

## Usage

Generate a new Dotnet Console Application: 
`cookiecutter gh:taylorgoodallau/cookiecutter-dotnet-console`. 

You'll be prompted a few questions to help this cookiecutter template to scaffold this project and after its completed you should see a new folder at your current path with the name of the project you gave as input.

It is reccomended you format the codebase once you're ready to use it.

**NOTE**: After you understand how cookiecutter works (cookiecutter.json, mainly), you can fork this repo and apply your own mechanisms to accelerate your development process and this can be followed for any programming language and OS.

## Options


Option | Description
------------------------------------------------- | ---------------------------------------------------------------------------------
`name_of_project` | Name of your project
`project_short_description` | Describe your project
`solution_name` | Name of your solution
`project_name` | Name of your project ( Uses First option without spaces and _ i.e my_new_project )
`include_sentry` | [Sentry](https://sentry.io/welcome/)
`include_newtonsoft_json` | [NewtonSoft](https://www.newtonsoft.com/json)
`include_aws_sqs` | ["Amazon SQS"](https://aws.amazon.com/sqs/)

## Credits
* This project has been generated with [Cookiecutter](https://github.com/audreyr/cookiecutter)
* This project has been modeled of [cookiecutter-aws-sam-dotnet](https://github.com/aws-samples/cookiecutter-aws-sam-dotnet)


## License Summary

This sample code is made available under a modified MIT license. See the LICENSE file.