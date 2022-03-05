# ToDoAndTracker

A ToDo app with a time tracker.

## Design

### Terms

- Project: A project can be an one-time work or a recurring work or even a habit.
  - Can contains a bunch of tasks.
  - It can be categorized into several types (like work, study, household, exercise, leisure) to generate reports.
  - Each one has a create date and a deadline date. The actual start fime can be calculated from the task.
  - Uses tags to mimic folders for projects.
- Task: A step in a project to be done.
  - Can set a timestamp of the expected start time and one for the end time, and also an estimate duration to complete it. The expected end time is when it should be completed, so it can be later than start time + estimate duration.
  - The real executing time is tracked by events.
  - Tasks are mainly for planning purpose. With such design, if plan well, idealy at a specific timespot there should be only one task to deal with.
  - Tasks can also recur by either every x num of mins/hrs/days, or on a fix timestamp every day/month/year.
- Event: The real hands-on time for a task.
  - Events are used to track how a task is done.
  - One task can have multiple events. If an event is interrupted, then the current event should be ended and a new event should started.
  - This design encourages focusing on one task at a time. But in case if doing two tasks in one event and lose track, evenly split the time.
  - Can also have a rate of work efficiency. This can be used to track the most efficient time in a day.

### Views

#### Event tracker

Remind what to do at current moment.

At top should be a text input which allows to input an unplanned task name. It will create an task in an unplaned project (all the unplaned task come here first). Then start an event of this task.

If currently there is an ongoing event, show how long has it been since start, else, wait to select a task.

Then show a list of projects with tasks need to do at this time. Should allow sort by project create time, deadline, priority.

#### Planner

Basically a todo app.

Show a list of tags on the left. Should also provide a way to filter tags to show on this list by toggle the visibility of a tag.

Click a tag can show a list of projects in the middle. Should provide a way to sort those projects, by created time, deadline, priority, the first undone task's expect start time. Allow to hide or display completed projects.

Click a project can bring up the details on the right. The details include a list of tasks and the project note. Can also edit the project name, note and tasks associate with it. Tasks are sorted by task step num. The step num can be changed here. Can hide or display not-in-progress tasks.

Tasks should only have names. All other details should be recorded in the note.

#### Project Report Page

Left bar shows a list of tags similar to planner. Middle bar shows a list of projects which are similar to planner as well. In the right shows the project report.

The propject report shows if the project is completed, since the first task starts how long has spent. List each task and their events' efficiency, and then the project note.

#### Calendar Report Page

Shows a calendar. In the top can select month. In the left list tags and projects.

In each cell of the calendar, list all the projects of the day. Should be able to distinguish if all the tasks have been done on that day. It can be decided later.

Can also show an efficiency view. It lists all daily efficiencies by how many task is done. This can be decided later.

#### Daily Report Page

Day report shows how a day is spent. A list of projects that is expect to start and the tasks that are done. Then show keynotes from previous diaries.

At the bottom there is a text box for write dairy.

### Models

#### User

**TODO**

#### Project

See [terms](#Terms).

Properties

- id
- name
- create date
- deadline date
- project note: a link
- tasks: an array ref to Task
- tags: ref to Tag. Tag is a class because when assign a tag to a project, we want to easily select from a list of tags
- category: (work, household, SelfImprove, health, leisure)
- involvedUsers: an array of userIds as foreign keys. Not use User ref as users are probably already created
- isArchieved: whether to archieve the project so it doesn't appear

Keywords are in note because search keywords should show notes instead of the project. Note has ref to the project.

#### Task

See [terms](#Terms).

Properties

- id
- name
- projectId: a foreign key to Project. Why not create it as a ref, because when create task the project would probably already created.
- priority: notAnalysed, high, medium, low. When sort, notAnalysed should show first, as it would be highest priority.
- step num: used to sort tasks in a project
- expected start time: a timestamp
- expected finish time: this is when the task must done. By default is the EOD of the start time.
- expected time duration: this is how long should it take
- state: can be queued/started/blocked/completed/abandoned
- recur rule: a formatted string. can set to be every x days, or on a fix date. when complete or abandon this task, create the next one.
- events: an array ref to Event. Actual start and complete time can be calculated by the events when the state is completed/abandoned.
- assignedUser: the userId. It should be within the involved user of the project. Also all the involved user can see the task, but assignedUser actually works on the task

TODO

- difficulty: how hard the task is. Not in use for now but put in track.

#### Event

See [terms](#Terms).

Properties

- Id: don't need a name
- taskId: a foreign key to Task
- start time: index it so that building a report is efficient
- end time: index it so that if it is null, it is the current on going event.

TODO

- rate of efficiency
- diary ref: link to a diary. Can use this to build a calendar view to see what event occurs on which date.

#### Tag

Just a list of strings that are uniq.

Properties

- Name

#### ProjectNote

Should contain a rich format text (maybe just put an onenote link?), related file paths and an email folder name (idealy link to all emails, but might be hard. Just record the name) in the note. It can link to a list of keywords.

Seperate note from Project so that it is more extendable.

Properties

- Project Id Ref
- keywords list: I suspect EF still creates a table for it. (build index?)
- content: for now it could be a just path to a onenote link. All the other things can be recorded in the onenote.

#### Diary

Should include a report of a day (generate when view it), a paragraph of the feeling, and some key takeaway to show later.

Properties

- Date
- content
- event ref list
- takeaway ref list: this is many-to-many relationship, because some takeaways can occur from multiple days, like the recurring ones.

#### Takeaway

The take away from a diary. The difference between it and a task is that this is not something to do, but something to think, like be focus. It can appear repeatly.

Properties

- Content
- Diary ref: Next Reminder Date can be recorded it here.

### Security

Should encrypt all the data.
