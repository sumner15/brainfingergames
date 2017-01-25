BrainFingerGames is intended to be an all-in-one suite for any FINGER based games used with the iMove version of FINGER. It also retains functionality to record physiological signals using a BCI2000 data logger or an arduino pulse-sync. To build the code, you will need to register the robot's COM object interface library, guitar2COMiface.dll, which is located in the source code under guitar2. To do this:

1 - open a command window as administrator
2 - navigate to ../guitar2/
3 - "regsvr32 guitar2COMiface.dll 
4 - close the command window
5 - Open the brainfinger games solution 
6 - Navigate to 'My Project/References'
7 - There may already be a guitar2COMiface or an empty com object registered. If there is, you will need to 'remove' it before adding the new object. 
8 - Click add and navigate to the COM tab to find guitar2COMiface
9 - Rebuild the solution