# instrumentDatabaseV1.0

READ ME
Instrument Library Filer v 1.0
Code by Matthew Raymond

Reason for Writing the Code:

I began working on this code because I was working in the instrument checkout room at my school and
I was getting frustrated at the fact that we were just using a basic .xcel file for all of our
record-keeping. There were constant formatting issue and no way to keep things clean and
self-contained, and there was a lot of repetitive typing.

This program was written as an attempt to cut down on as much typing as possible and to make
everything very clean, fast, straightforward, and accessible.

I haven't done it yet, but I plan on presenting this program to my boss when it's mostly finished
and asking him if we can use this instead of just an excel file, beacuse I think that it would be
much more convenient in the end.

tldr; I wanted to improve my workplace.


Instructions:

Right click on the .exe and create a chortcut on the desktop. This will be much easier than just
using the .exe because you won't have random files on your desktop.

The first time the program is opened, it will create a directory and populate it with .xml files.
Any time that it’s opened after than, it will read from those files. However, if one gets corrupted,
the program will try to correct itself and just make a new file to replace the old one.

If there are no employees in the system, an "Add Employees" window will open. Simply type in the
employee's first and last name and click "Add" to add them. You can add as many as you want, and
then click "Enter" to continue.

A new "Select" window pops up and prompts you to choose a user from the list. You can select one,
or click "Other User" if you don't want fields autofilled for you.

To add an instrument, simply click "Add Item" and follow the prompts on screen. This data can be
displayed by clicking on an instrument in the list and looking to the right of the filter buttons

You can use the tabs on the right of the instrument list to filter out only one type of instrument,
and you can use the search bar at the top in order to search for specific instruments by
name/id/etc.

In order to check in/out the instrument, click the appropriate button on the botton left and follow
the prompts on screen. If you have the appropriate card reader, this is where you will be able to
use it to enter the student's ID number.

When a student checks something in or out, they automatically get added to the system and their
information will autocompleted the next time their ID is entered into this window.

A note can be added to the transaction by clicking "Add Note".

At any point, "Save Changes" can be clicked in order to save the current information to the disk.

If the instrument goes missing for whatever reason, this status can be updated by clicking the
"Missing Status" button, which will set the status from found to missing, or vice versa.

To delete an item, click the "Delete Item" button, and select items from the checked list. To
select/deselect all, click "All".

In order to view a log of all of the transactions that have taken place for the highlighted
instrument, click "Check In/Out Log". All of this data is editable if you double-click the text in
the cell. All of these edits are automatically saved to RAM, but you have to click the save button
to permanently save them.

To export a .csv file containing all of the instruments data and the instruments' check in/out
information, click "Export .csv File", which will export a file to your data directory.

To add employees or change the current working employee, simply click those buttons on the top
right.



General Notes:

The way that this program is currently set up to run, it will save all of its files into the same
location as the .exe file is saved in. However, in future versions I plan to make it so that the
user can choose a location for the files to be saved in.

This program was built to run with an IdTech IDMB-334112B MiniMag II Magstrip Reader.
When our student ID cards are swiped, the swipe returns numbers in the format ";00xxxxxxx=yyyy?"
where x's are the ID number and y's are irrelevant chars. As of now, the only field in which this
works is the field marked “Student ID” in the check out/in winform. This code could be slightly
modified to work with other card readers, but I would need to do some research in order to support
others. It doesn’t really matter though, as you can type in the information by hand anyway.

Additionally, the email domains are hard-coded in and are specific to my school, but with some very
basic programming skills someone would be able to alter them to work wit whatever email domains.


Future Plans:
- Record time of checkout
- Prevention of accidental duplications in student database (i.e. multiple ID#’s being assigned the
  same name)
- Edit saved student data
- Edit saved instrument data
- Revamp instrument sorting (instead of a different list for every section)
- .csv file importing
- More robust and extensive error handling
- Exporting .csv files to specific filepaths
- More advanced search capabilities (i.e. search criteria separated by commas, and displaying
  names that contain the search input as a substring)
- Basic password or ID verification for employees
- Automatically sort instruments by instrument ID
- Record of past transaction notes kept (old notes are kept for filing purposes)
- Analytical tools to improve scheduling and resource allocation (potentially via graphs)
  - Number of transactions for each instrument/type of instrument
  - Instruments ordered in most recently checked out/in
  - Most common time of day for instrument check ins/outs
  - Most common day of the week to check out/in instruments
  - Fluctuation of transaction by week
- Support for more card reader types
- Potentially enabling it to access the school’s database of ID numbers so that you don’t ever
  need to type in student information
- Monthly backup system
  - Ability to import old .xml files to look at old data
- Display a list of students and see what they have checkout out to their name
- Programmatic colors on filters to know what's pushed and what is't


Resources Used:
- Music folder icon:
  - Artist: shaunkleyn
  - License: Free for non-commercial use.
  - Source: iconarchive.com/show/phlat-blue-folders-icons-by-shaunkleyn/Music-icon.html
