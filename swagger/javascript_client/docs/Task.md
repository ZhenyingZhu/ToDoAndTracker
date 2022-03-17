# ToDoAndTracker.Task

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **Number** |  | [optional] 
**name** | **String** |  | 
**projectIds** | **[Number]** |  | [optional] 
**priority** | **String** |  | [optional] 
**stepNum** | **Number** |  | [optional] 
**expectedStartTime** | **Date** |  | [optional] 
**expectedFinishTime** | **Date** |  | [optional] 
**expectedTimeDuration** | **String** | [ISO_8601](https://en.wikipedia.org/wiki/ISO_8601#Durations) | [optional] 
**state** | **String** |  | [optional] 
**recurRule** | **String** |  | [optional] 
**events** | [**[Event]**](Event.md) |  | [optional] 
**assignedUser** | **Number** |  | [optional] 

<a name="PriorityEnum"></a>
## Enum: PriorityEnum

* `notAnalysed` (value: `"notAnalysed"`)
* `high` (value: `"high"`)
* `medium` (value: `"medium"`)
* `low` (value: `"low"`)


<a name="StateEnum"></a>
## Enum: StateEnum

* `queued` (value: `"queued"`)
* `started` (value: `"started"`)
* `blocked` (value: `"blocked"`)
* `completed` (value: `"completed"`)
* `abandoned` (value: `"abandoned"`)

