# EliteFIPProtocol

EliteFIPProtocol started out as a way to provide a common protocol package for the [Elite FIP Server](https://github.com/EarthstormSoftware/EliteFIPServer)
to send Elite Dangerous game data to client applications via UDP in a defined format, and for clients 
to be able to register to receive that data, and potential trigger other activities.

At the time, the intention was to write a native Windows UWP app to complement the server and to provide 
a 'virtual' Flight Instrument Panel using a Windows touch screen device. Since then, the author of 
[Matric](https://matricapp.com/) has released an experimental Windows client, which does the heavy 
lifting between Client and Matric server, so the requirement for a specific protocol is reduced.
Even so, the Elite FIP Server continues to use this project, and it will remain and be expanded 
alongside the server as required, in case of potential future use.
