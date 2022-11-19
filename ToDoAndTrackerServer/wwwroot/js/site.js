// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const projectUri = '/api/projects';
const taskUri = '/api/tasks';
let tasksByProject = [];
let selectedProjectId = -1;

function getTasksByProject(projectId) {
    // zhenying: think whether to set it first or set it after?
    selectedProjectId = projectId;

    fetch(`${projectUri}/${projectId}/tasks`)
        .then(response => response.json())
        .then(data => _displayTasksByProject(data))
        .catch(error => _displayErrorMessage('Unable to update project.', error));
}

function _displayTasksByProject(data) {
    const tBody = document.getElementById('tasksByProject');
    tBody.innerHTML = '';

    const button = document.createElement('button');

    data.forEach(task => {
        let tr = tBody.insertRow();

        let taskNameTextNode = document.createTextNode(task.name);
        let td1 = tr.insertCell(0);
        td1.appendChild(taskNameTextNode);

        let taskStateTextNode = document.createTextNode(task.state);
        let td2 = tr.insertCell(1);
        td2.appendChild(taskStateTextNode);

    //    let checkButton = button.cloneNode(false);
    //    checkButton.innerText = 'Check';
    //    checkButton.setAttribute('onclick', `_displayProjectEditForm(${project.id})`);
    //    let td3 = tr.insertCell(2);
    //    td3.appendChild(checkButton);
    });

    tasks = data;
}

function _displayErrorMessage(msg, error) {
    console.error(msg, error);
    // const errorPara = document.getElementById('projectErrorMessage');
    // errorPara.innerText = msg;
    // errorPara.style.display = 'block';
}
