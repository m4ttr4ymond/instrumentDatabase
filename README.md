# READ ME

Instrument Library Filer v 1.0

Code by Matthew Raymond

Overview:

This program was written as an attempt to cut down on as much typing as possible
and to make everything very clean, fast, straightforward, and accessible.


Instructions:

Right click on the .exe and create a shortcut on the desktop. This will be much
easier than just using the .exe because you won't have random files on your
desktop.

The first time the program is opened, it will create a directory and populate it
with .xml files. Any time that it’s opened after than, it will read from those
files. However, if one gets corrupted, the program will try to correct itself
and make a new file to replace the old one.

If there are no employees in the system, an "Add Employees" window will open.
This first employee must be an admin. You cannot create a non-admin employee
until you have at least one admin. To create an employee, simply type in the
employee's first and last name and click "Add" to add them. If the user is an
admin, you will be prompted to add a password. You can add as many as you want,
and then click "Enter" to continue.

A new "Select" window pops up and prompts you to choose a user from the list.
You can select one, or click "Other User" if you don't want fields autofilled
for you.

To add an instrument, simply click "Add Item" and follow the prompts on screen.
This data can be displayed by clicking on an instrument in the list and looking
to the right of the filter buttons

You can use the tabs on the right of the instrument list to filter out only one
type of instrument, and you can use the search bar at the top in order to search
for specific instruments by name/id/etc. using regular expressions ("," for each
instrument and "+" to search for more than one criteria for each instrument).

In order to check in/out the instrument, click the appropriate button on the
bottom left and follow the prompts on screen. If you have the appropriate card
reader, this is where you will be able to use it to enter the student's ID
number.

When a student checks something in or out, they automatically get added to
the system and their information will autocompleted the next time their ID is
entered into this window.

A note can be added to the transaction by clicking "Add Note".

At any point, "Save Changes" can be clicked in order to save the current
information to the disk.

If the instrument goes missing for whatever reason, this status can be updated
by clicking the "Missing Status" button, which will set the status from found to
missing, or vice versa.

To delete an item, click the "Delete Item" button, and select items from the
checked list. To select/deselect all, click "All".

In order to view a log of all of the transactions that have taken place for the
highlighted instrument, click "Check In/Out Log". All of this data is editable
if you double-click the text in the cell. All of these edits are automatically
saved to RAM, but you have to click the save button to permanently save them.

To export a .csv file containing all of the instruments data and the
instruments' check in/out information, click "Export .csv File", which will
export a file to your data directory.

To add employees or change the current working employee, simply click those
buttons on the top right.

To restore from a backup, click "Import Backup" and and select a backup to
restore from. Only admin accounts can restore from backups.

To see data about students, instruments, and employees, select "Analytics". You
will be taken to a window that displays that information. Once there you can see
information about the general dataset in the graph at the top left, and
individual datasets will be in the graph at the bottom left. You can change the
individual dataset by selecting one from the list int the middle/right of the
screen, and you change change the general dataset by selecting one of the radio
buttons marked "Student", "Employee", or "Instrument". By using the calendars to
the right, you can select the date range that you want the data to be selected
from.

To see information about individual students, select "Student Data". Double-
clicking a student pulls up a window that lists their transaction history.





General Notes:

This program was built to run with an IdTech IDMB-334112B MiniMag II Magstrip
Reader. When our student ID cards are swiped, the swipe returns numbers in the
format ";00xxxxxxx=yyyy?" where x's are the ID number and y's are irrelevant
chars. As of now, the only field in which this works is the field marked
“Student ID” in the check out/in winform. This code could be slightly modified
to work with other card readers, but I would need to do some research in order
to support others. It doesn’t really matter though, as you can type in the
information by hand anyway.

Additionally, this program has built in support for TaoTronics USB Barcode
Scanner 0878130. Click on the search button on the main winform and scan a
barcode in order to search the library for that instrument.

Furthermore, the email domains are hard-coded in and are specific to my school,
but with some very basic programming skills someone would be able to alter them
to work wit whatever email domains.


Changelog:

v 1.2

- Bug Fixes
  - Fixed crash when opening check in/out log and list is empty
  - Fixed a bug that caused .csv files to print checkout dates in reverse order
  - Fixed the bug that let you delete your own account
  - Fixed the fatal error when searching an empty database
  - Fixed the fatal error for pressing backspace in an empty search bar
  - Fixed the bug that allowed people to check out an instrument that's out or
    return one that not

- New Features
  - Some regular expressions: and (+), or (,)
  - Live search update(search will return strings that have the search criteria
    as a substring)
  - Basic password verification for employees
    - Admin account is prompted if there are no accounts
    - Admin creates new employee accounts with password (saved in a SHA256
      hashed version for security)
    - Admin only events, like restoring from backups, adding and deleting
      instruments, and adding and deleting employees
    - A guest account can be used by not logging in, which only lets you view
      data
  - Manually restore from backup, which can be chosen via file explorer
  - .csv files can be exported anywhere via the file explorer
  - Added "N/A" autofill for the "bow" entry if the instrument category doesn't
    have bows (this can be manually changed)
  - Added Basic analytics to tell what day of the week is the most trafficked
  - .XML files are now encrypted via Rijndael Cypher to keep personal records
    and library data secure
  - Added a display to show what students have checked out things, and what
    things they've checked outs
  - Broke up the checkout note into multiple lines if it's too long for one line


v 1.1

- Bug Fixes
  - Corrected null entry bugs
  - Corrected user entry bugs
  - Streamlined window movement

- New Features
  - Ensure that id number is as long as it should be (first entry and log edit)
  - Automatic backup every other week (must be opened every other week for this
    to work)
    - Import last backup in case of catastrophic failure
  - Barcode scanner support


Future Plans:

- Edit saved student data
- Edit saved instrument data
- Revamp instrument sorting (instead of a different list for every section)
- .csv file importing
- More robust and extensive error handling
- Exporting .csv files to specific filepaths
- More advanced search capabilities (i.e. search criteria separated by commas,
  and displaying
  names that contain the search input as a substring)
- Basic password or ID verification for employees
- Automatically sort instruments by instrument ID
- Record of past transaction notes kept (old notes are kept for filing purposes)
- Analytical tools to improve scheduling and resource allocation (potentially
  via graphs)
  - Number of transactions for each instrument/type of instrument
  - Instruments ordered in most recently checked out/in
  - Most common time of day for instrument check ins/outs
  - Most common day of the week to check out/in instruments
  - Fluctuation of transaction by week
- Support for more card reader types
- Potentially enabling it to access the school’s database of ID numbers so that
  you don’t ever
  need to type in student information
- Display a list of students and see what they have checkout out to their name
- Record time of checkout
- Prevention of accidental duplications in student database (i.e. multiple ID#’s
  being assigned
    the same name)
- Add autofill N/A for bow
- On Check In/Out Log Employee Column edit, open up employee window to ensure
  that correct
  employee is chosen
- Programmatic colors on filters to know what's pushed and what isn't
- Choose which backup to open


Resources Used:
- Music folder icon:
  - Artist: shaunkleyn
  - License: Free for non-commercial use.
  - Source: iconarchive.com/show/phlat-blue-folders-icons-by-shaunkleyn/Music-icon.html
