# schedulync
WAN/ LAN based multi-user scheduling system for Windows

Initially I hosted this project on another GIT, but has been moved to my personal GIT.
THe calendar is designed to pull in multiple users from a LAN and automatically add them to the calendar once they sign up. 
It is accesible from the internet, with planned implementations of SMS messaging.

It is a fully customizable calendar. The color themes along with avatars can changed and will immediately update across all user's calendars.

Currently, the calendar will load, but is missing the scheduling logic memory logic and efficiency of background updating of multiple users.

To be implemented is also unlimited multi-user. Limit is 11 users.

First run will allow a user to link to a NoSQL database, or create a new one and enter their information.
If a master database exists, the new user's information will be added, and all user's calendars will update.
