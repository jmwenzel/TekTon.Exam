# Technical Test

Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of the line i is at (i, ai) and (i, 0). Find two lines, which, together with the x-axis forms a container, such that the container contains the most water.

# Project Solution

## TekTon.Exam.API
NET Standard project that contains a Container class with one single method: MaxArea. It receives an array of integers and calculates the area with most water

## Tekton.Exam.API.Test
NET Core test project with one class: ContainerTests. In order to test the results run the MaxArea_Returns_Expected() method. 
