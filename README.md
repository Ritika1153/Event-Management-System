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
</ul>

<h2>Examples</h2>
<p>Here are some examples of how to use the commands:</p>

<ul>
    <li>To create a new event, just type: <code>create</code></li>
    <li>To get details of event with ID 1, type: <code>get 1</code></li>
    <li>To delete the event with ID 1, type: <code>delete 1</code></li>
    <li>To update the event with ID 1, type: <code>update 1</code></li>
</ul>

<h2>System Design</h2>
<p>This system uses the concept of <strong>Partial Classes</strong> to separate concerns and keep the code modular. The main operations (Create, Update, Delete, List) are handled by specific event action classes found in the <code>actions/</code> folder, while the event model and data management logic are located in the <code>models/</code> folder.</p>

<h2>Getting Started</h2>
<p>To get started with the Event Management System:</p>
<ol>
    <li>Clone the repository to your local machine.</li>
    <li>Install any required dependencies (if applicable).</li>
    <li>Run the system via your preferred method (CLI, terminal, etc.) and use the commands mentioned above.</li>
</ol>

<h2>Contributing</h2>
<p>If you'd like to contribute to the Event Management System, feel free to fork the repository, make changes, and submit a pull request. We welcome improvements, bug fixes, and feature additions.</p>

<h2>License</h2>
<p>Include your project’s license here (e.g., MIT, GPL, etc.).</p>

</body>
</html>
