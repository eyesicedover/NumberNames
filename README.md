
# Number Names

#### By Jasun Feddema & Stephanie Faber

## Description
A webapp that converts a number to its written out long-form equivalent.

## Specifications
* Take input from the user.
  - example input: 1200318
  - example output: "1200318"

* Convert user string input into a char array
  - example input: "1200318"
  - example output: array chars[] = {"1", "2", "0", "0", "3", "1", "8"}

* Convert char array into int list
  - example input: array chars[] = {"1", "2", "0", "0", "3", "1", "8"}
  - example output: array numbers[] = {1, 2, 0, 0, 3, 1, 8}

* Starting at end, group into new list by three integer list chunks
  - example output: array numbers[] = {1, 2, 0, 0, 3, 1, 8}
  - example output: list chunks[] = {list{1}, list{2, 0, 0}, list{3, 1, 8}}

* Reverse order of list
  - example output: list chunks[] = {list{1}, list{2, 0, 0}, list{3, 1, 8}}
  - example output: list reverseChunks[] = {list{3, 1, 8}, list{2, 0, 0}, list{1}}

* Determine string based on position of number in each chunk list
  - example output: list reverseChunks[] = {list{3, 1, 8}, list{2, 0, 0}, list{1}}
  list reverseChunks[0] = list{3, 1, 8}
  - example output: string result = "three hundred eighteen"

  * Account for the numbers 10 through 19, which have different naming conventions
  - example input: list reverseChunks[] = {list{3, 1, 8}, list{2, 0, 0}, list{1}}
  reverseChunks[0] = list{3, 1, 8}
  list[1] = 1
  list[2] = 8
  - example output: result string = "eighteen"

* Account for zeroes in the number, skipping to the next number
  - example input: list reverseChunks[] = {list{3, 1, 8}, list{2, 0, 0}, list{1}}
  reverseChunks[1] = 200;
  - example output: string result += ""
  result = "three hundred eighteen"

* Cycle through each chunk and add the correct suffix based on position
  - example output: list reverseChunks[] = {list{3, 1, 8}, list{2, 0, 0}, list{1}}
  reverseChunks[1] = list{2, 0, 0}
  string chunk1 = "two hundred"
  string suffix1 = "thousand"
  result = chunk1 + suffix1 + result
  - example output: string result = "two hundred thousand three hundred eighteen"

* Return string result to user
  - example input: 1200318
  - example output: "one million two hundred thousand three hundred eighteen"


## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/eyesicedover/NumberNames.git'.
* run the command 'dotnet restore' to download the necessary packages.
* run the command 'dotnet run' to build and run the server on localhost.
* use your preferred web browser to navigate to localhost:5000


## Support and contact details

* contact the author at chamburg321@gmail.com

## Technologies Used

* C#
* Asp .NET Core MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Jasun Feddema & Stephanie Faber

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
