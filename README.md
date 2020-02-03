# ToDoAndTracker

A ToDo app with a time tracker.

## Design

### Views

#### Event tracker

Can show a list of tasks need to do at this time. Should allow sort.

At top should be a text input which allows to input a new event. This event will bind to an unplaned task in an unplaned project (all the unplaned task come here).

#### Plan

Show a list of tags on the left. Should also provide a way to select tags to show on this list.

Click a tag can show a list of projects in the middle. Should provide a way to sort those projects.

Click a project can bring up the details on the right. The details include a list of tasks and a note. Can also edit the project and tasks associate with it.

Tasks should only have names. All other details should be recorded in the note.

#### Report Page

Three kinds of reports: per day, per project and an efficiency view. Should allow to select as a drop down list in the nav bar.

Day report shows how a day is spent. A list of projects that is expect to start and the tasks that are done. Then show keynotes from previous diaries, and then allow to write a new diary.

Project report shows a caldendar with how each tasks is done.

Efficiciency view is a caldendar with all daily efficiencies by how many task is done. This can be decided later.

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
- is completed

#### Note

Maybe seperate note from Project so that it is more extendable.

Properties

- Project Id Ref
- keywords list (build index?)
- path to a onenote link

#### Keyword

Note can have a list of keywords for search.

Properties

- keyword

Keyword not backlink to notes because I'd like to see if .NET support such query. I suspect internally it is still stored as a foreign key table.

#### Task

A step in a project to be done. Can set a range of time to deal with it, also an estimate duration to complete it. With such design, in a specific timespot there could be multiple tasks need to be work on. It is fine because this is for plan purpose. It should also have a rate of how hard it is. Tasks can also recur. It can be binded to a list of events.

Properties

- task name
- project id ref
- expect start time
- expect complete time (this is when must done. By default EOD of the start time.)
- expect time duration (this is how long should it take)
- expect hard rate
- is completed/abandoned
- how soon to recur
- event list

#### Event

The real hands-on time for a task. It is a track of how a task is done. If an event is interrupted, then it becomes to two events. Can also have a rate of work efficidency.

Properties

- task id ref
- project id ref
- start time
- end time
- is currently work on (index)

#### Tag

This is used to tag projects. Some tags can be shown on the page. Tags can have a hierarchy, i.e., like folders. The root tag is "all".

Properties

- tag name
- children tag list

#### Diary

Should include a report of a day, a paragraph of the feeling, and some key takeaway to show later.

Properties

- Date
- text
- takeaway list

#### Takeaway

The take away from a diary. It can appear repeatly.

Properties

- text
- Date list

### Storage

Should encrypt all the data.
