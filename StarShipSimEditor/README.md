The workflow for the builds is available here;
https://github.com/CSIClough/StarShipSimEditor/actions

By default the app will open the databases on it's own, if it fails to and shows "no database selected" at the top, click on "Select Database Folder" and navigate to the steam fodler where starship simulator stors the database and click on open.
This is usually found in the following location unless a custom location has been specified in Steam.
C:\Program Files (x86)\Steam\steamapps\common\Starship Simulator Dev Playtest\StarshipSimulator\Content\

Clicking on the drop box against "Object Name" will show all the objects in the Celestial Objects table by default. 

To edit an entry select it and modify the fields as needed then click on "Save Changes"

To create a new entry either enter the fields as needed or select an existing object as a template and click on "Clone Current" then modify as required before clicking on "Save Changes"

Currently stars can only be viewed they can't be edited - this is very much WIP and may result in errors.

The Gaia tab can be selected but will take a while to load in, selecting it will provide a prompt prior to loading the data and will pause every 1 million entries.

TODO: 

Include data restrictions to stop invalid data being entered. - Started 01/06/2025

Include support for stars being added properly. - Started 05/06/2025

Make it obvious when in clone mode. - Done 01/06/2025

Cleanup Gaia database query to make it faster - Done 10/6/2025

Integrate Gaia data query into custom systems. - Done 10/6/2025