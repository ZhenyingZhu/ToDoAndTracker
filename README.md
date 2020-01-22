# ToDoAndTracker

A ToDo app with a time tracker.

## Design

### Views

#### Event tracker

Can show a list of tasks need to do at this time. Or input a new event, which will bind to a un expected task.

#### Plan

Show a list of tags on the left. A way to select tags to show on this list.

Click a tag to show a list of projects in the middle.

Click a project to edit the project and tasks associate with it.

#### Report Page

Report how a day is spent.

### Models

#### Project

A project which can be a one-time work or a recurring work or even a habit. Can have a bunch of tasks. It can be categorized into several types, like work, study, household, exercise, leisure to generate reports. It can also have tags. It can also have a link to a note (put related files and email folders in the note). Also a list of keywords. Can have a create time, start time and deadline.

Properties

- Project Id
- Project Name
- Type (work, study, household, health, leisure)
- create time
- start time
- deadline
- note ref
- tags list
- tasks list

#### Note

Maybe seperate note from Project so that it is more extendable.

Properties

- Project Id Ref
- keywords list
- path to a onenote link

#### Keyword

- keyword

#### Task

A step in a project to be done. Can set a range of time to deal with it, also an estimate duration to complete it. With such design, in a specific timespot there could be multiple tasks need to be work on. It is fine because this is for plan purpose. It should also have a rate of how hard it is. Tasks can also recur. It can be binded to a list of events.

Properties

#### Event

The real hands-on time for a task. It is a track of how a task is done. If an event is interrupted, then it becomes to two events. Can also have a rate of work efficidency.

#### Tag

This is used to tag projects. Some tags can be shown on the page. Tags can have a hierarchy, i.e., like folders. The root tag is "all".

#### Keyword

Project can have a list of keywords for search.

#### Report

Still thinking about if it should be a stored entity or a dynamically generated thing. It should list all the tasks done in a time range, compare to the task plan. Another kind of report is based on a project. Show how much days on a calendar does this project takes, and how much the progress is.

#### Dairy

Should include a report of a day, a paragraph of the feeling, and some key takeaway to show later.

### Storage

Should encrypt all the data.
