# Unity-Application-Accessor
    With this script implemented into a Unity Project, you will be able to open applications from directly within Unity without having to go through the trouble of switching tabs or searching through your desktop. It makes testing games in Unity more efficient, as you can launch a certain file within a program without having to boot the program up first and then opening it the file up inside the program.
    
    To add your application to be opened with this script, the following code should be injected:
    
    makeButton("\"[Name of Application]\"", @"[File Path of Application]");

    To find the file path of your application, go to the location of the executable in your PC's "files" and copy the path.
