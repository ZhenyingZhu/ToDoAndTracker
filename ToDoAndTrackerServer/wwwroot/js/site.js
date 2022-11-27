// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const projectUri = '/api/projects';
const taskDetailUri = '/Todo/Tasks/Details?id=';
const tasksCountElement = 'tasksCount';
const tasksByProjectTableElement = 'tasksByProject';
const createTaskNameElement = 'createTaskName';
const createTaskStateElement = 'createTaskState';
const projectEntryPrefix = 'projectEntry';

let tasksByProject = [];
let selectedProjectId = -1;

/**
 * Add a task to a project. The input is retrieved from the form.
 * Called when submit the addTaskToProjectForm.
 */
function addTaskToProject() {
    // TODO: check if selectedProject is not -1.
    const createTaskName = document.getElementById(createTaskNameElement);
    const createTaskState = document.getElementById(createTaskStateElement);

    const task = {
        name: createTaskName.value.trim(),
        state: createTaskState.value.trim()
    };

    fetch(`${projectUri}/${selectedProjectId}/tasks`, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(task)
    })
        .then(response => response.json())
        .then(() => {
            getTasksByProject(selectedProjectId);
            createTaskName.value = '';
            // zhenying: anyway to not hard code it here?
            createTaskState.value = 'Backlog';
        })
        .catch(error => console.error('Unable to add item.', error)); // Handle error.
}

/**
 * @param {int} projectId
 * Called when need to display the tasksByProject table with latest data.
 */
function getTasksByProject(projectId) {
    console.log(`getTasksByProject ${projectId}`);
    fetch(`${projectUri}/${projectId}/tasks`)
        .then(response => response.json())
        .then(tasks => {
            tasksByProject = tasks;
            _displayTasksByProject();
        })
        .catch(error => _displayErrorMessage('Unable to fetch tasksByProject.', error, 'tasksErrorMessage'));
    selectedProjectId = projectId;
}

/**
 * Display the tasksByProject table based on stored selectProjectId and tasksByProject list.
 */
function _displayTasksByProject() {
    console.log(`_displayTasksByProject ${selectedProjectId}`);

    if (selectedProjectId === -1) {
        return;
    }

    const projectEntry = document.getElementById(projectEntryPrefix + selectedProjectId);

    const countBody = document.getElementById(tasksCountElement);
    countBody.innerHTML = `In total ${tasksByProject.length} task(s)`;

    const tableBody = document.getElementById(tasksByProjectTableElement);
    tableBody.innerHTML = '';

    const hrefLink = document.createElement('a');

    tasksByProject.forEach(task => {
        let tr = tableBody.insertRow();

        let taskNameTextNode = document.createTextNode(task.name);
        let td1 = tr.insertCell(0);
        td1.appendChild(taskNameTextNode);

        let taskStateTextNode = document.createTextNode(task.state);
        let td2 = tr.insertCell(1);
        td2.appendChild(taskStateTextNode);

        let taskDetailLink = hrefLink.cloneNode(false);
        let detailText = document.createTextNode("Detail");
        taskDetailLink.appendChild(detailText);
        taskDetailLink.title = "task detail";
        taskDetailLink.href = `${taskDetailUri}${task.id}`;
        let td3 = tr.insertCell(2);
        td3.appendChild(taskDetailLink);

        let taskDeleteButton = hrefLink.cloneNode(false);
        taskDeleteButton.innerText = 'Delete';
        taskDeleteButton.setAttribute('onclick', `_displayTaskDeleteForm(${task.id})`);
        let td4 = tr.insertCell(3);
        td4.appendChild(taskDeleteButton);
    });
}

/**
 * @param {int} taskId
 * Called when need to display the deleteTask form.
 */
function _displayTaskDeleteForm(taskId) {
    console.log(`_displayTaskDeleteForm ${taskId}`);
}

/**
 * @param {string} msg
 * @param {object} error
 * @param {string} errEleId
 * Called when need to display the error message in the error element.
 */
function _displayErrorMessage(msg, error, errEleId) {
    console.error(msg, error);
    const errorPara = document.getElementById(errEleId);
     errorPara.innerText = msg;
     errorPara.style.display = 'block';
}
