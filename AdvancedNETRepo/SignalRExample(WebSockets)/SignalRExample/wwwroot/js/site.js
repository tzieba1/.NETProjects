// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

// Needed to track user messages and rooms.
var userName;
var roomName;

// Creating the connection between client application and server and providing it with a URL is required.
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

// Event handler that calls another local method to handle the server request sending "ReceiveMessage".
// on() method must have message matching the one called by the server and the actual JS message handling that message.
connection.on('ReceiveMessage', displayMessage);

// Starting the connection after providing event handlers to send information to the client.
connection.start();

// Retrieve the form created for sending real time messages.
var msgForm = document.forms.msgForm;

// Add an event listener for the form.
msgForm.addEventListener('submit', function (e) {
  e.preventDefault();
  var userMessage = document.getElementById('userMessage');
  var text = userMessage.value;
  userMessage.value = "";

  userName = document.getElementById('username').value;
  roomName = document.getElementById('roomName').value;

  sendMessage(roomName, userName, text);
});


// Sending function used inside the event listener whenever someone submits a new message
function sendMessage(roomName, userName, message) {
  if (message && message.length) {
    connection.invoke("SendMessage", roomName, userName, message);  // Invoke SendAllMessages method from the server with its params
  }
}

// Sending function used inside the event listener to display a submitted message
function displayMessage(name, time, message) {
  // Use a friendly time format with hours, minutes, seconds.
  var friendlyFormatTime = moment(time).format('H:mm:ss');

  // Information about the user as list items.
  var userLi = document.createElement('li');
  userLi.className = 'userLi list-group-item';
  userLi.textContent = friendlyFormatTime + ", " + name + " says: ";  // Label for a message sent from someone at a certain time.

  var messageLi = document.createElement('li');
  messageLi.className = 'messageLi list-group-item';
  messageLi.textContent = message;  // The actual message sent from someone at a certain time.

  // Time, sender, and message appended to the unordered list.
  var chatHistoryUl = document.getElementById('chatHistory');
  chatHistoryUl.appendChild(userLi);
  chatHistoryUl.appendChild(messageLi);

  // To scroll down to newly added message.
  $('#chatHistory').animate({ scrollTop: $('#chatHistory').prop('scrollHeight') }, 50);
}

// Since this is an independent task (meant to happen before sending a message) joining a room can go beneath the inital code for just displaying a message.
document.getElementById("btnJoin").addEventListener('click', function (e) {
  e.preventDefault();

  // Gets the actual room name inside the textbox.
  var roomName = document.getElementById("roomName").value;

  // Check that roomname is non-empty and non-null
  if (roomName && roomName.length) {
    document.getElementById("btnJoin").disabled = true;

    // Must invoke on the connection to affect the server and use the JoinRoom method.
    connection.invoke("JoinRoom", roomName);
  }
})