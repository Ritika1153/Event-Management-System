<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

</head>
<body>

<h1>Event Management System</h1>

<p>Welcome to the Event Management System! This system allows you to manage events through simple commands for creating, updating, deleting, and listing events. Below is the guide on how to use the system.</p>

<h2>Folder Structure</h2>
<ul>
    <li><strong>models/</strong>: Contains the model classes for the Event entity.</li>
    <li><strong>actions/</strong>: Contains all the event-related actions (e.g., Create Event, Delete Event, etc.).</li>
</ul>

<h2>Commands</h2>
<p>The system supports the following commands:</p>

<ul>
    <li><strong>Create</strong>: Use this command to create a new event. Simply type <code>create</code> to initiate the event creation process.</li>
    <li><strong>Update</strong>: To update an existing event, type <code>update &lt;event_id&gt;</code>. Replace <code>&lt;event_id&gt;</code> with the ID of the event you want to update.</li>
    <li><strong>Delete</strong>: To delete an event, type <code>delete &lt;event_id&gt;</code>. Replace <code>&lt;event_id&gt;</code> with the ID of the event you wish to remove.</li>
    <li><strong>List</strong>: To list all events, simply type <code>list</code>.</li>
    <li><strong>List</strong>: To get an event, simply type <code>get &lt;event_id&gt;</code></li>
    
</ul>

<h2>Examples</h2>
<p>Here are some examples of how to use the commands:</p>

<ul>
    <li>To create a new event, just type: <code>create</code></li>
    <li>To get details of event with ID 1, type: <code>get 1</code></li>
    <li>To delete the event with ID 1, type: <code>delete 1</code></li>
    <li>To update the event with ID 1, type: <code>update 1</code></li>
    <li>To list the events, type: <code>list</code></li>
    
</ul>



</body>
</html>
