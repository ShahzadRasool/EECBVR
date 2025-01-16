# Enhancing Energy Conservation Behaviors Through Audiovisual and Social Cues in Virtual Reality
This repository contains Unity VR project and the associated information for the research on 'Enhancing Energy Conservation Behaviors Through Audiovisual and Social Cues in Virtual Reality'. The Unity project includes an indoor office environment with three types of intervention cues to encourage energy conservation actions within the VR environment.

### Layout of the Office Space
The office space includes 3 rooms, a storeroom, a central hall and a lift for entry/exit to the office space.
![](https://github.com/user-attachments/assets/4c618dd7-0655-4c73-a4ac-b2f7c7d8161b)

### Inside the VR
The following video shows the office environment and how it looks in VR. In this sample video, the different types of energy conservation posters are shown. It also shows how the user accomplishes a task within the office environment:
[![](https://raw.githubusercontent.com/aamna21/Enhancing-Energy-Conservation-Behaviors-Through-Audiovisual-and-Social-Cues-in-Virtual-Reality/tree/main/MediaFiles/thumbnail.JPG)](https://raw.githubusercontent.com/aamna21/Enhancing-Energy-Conservation-Behaviors-Through-Audiovisual-and-Social-Cues-in-Virtual-Reality/blob/main/MediaFiles/OfficeEnvironmentwithtask.mp4)
# Unity Project
This project is developed in Unity 2020.3.3f1 with the following Assets and components: 
## Assets Used
The project is structured with assets stored under the `Assets > EnvProject` folder. 
### Scenes:
The project includes a separate scene for each type of intervention cues. These include 
- `OfficeEnvironmentAudioAidsMore`
- `OfficeEnvironmentVisualAidsLessDense`
- `OfficeEnvironmentNPCIntervention`, etc.
- 
All the scenes are listed in the project hierarchy.

Scene name includes information about the intervention cues e.g. `OfficeEnvironmentVisualAidsLessDense` indicates that this scene has visual posters as intervention cues and their density across the environment is low, `OfficeEnvironmentAudioAidsMore` indicates that this scene utilizes periodic audio annoucements as intervention cues with high frequency of repetition. The scenes are:
### Scripts:
Custom scripts have been created for `Announcements` (control the frequencies of Announcements), `NPCIntervention` (control the NPC intervention between intervals) and some additional scripts relevant to scene management and interaction.
### Audios:
- Voice clips such as:
  - "If you are the last one, turn off the lights."
  - "Please turn off the lights when not in use."
- Background sound effects stored in the Audios folder.
### Models and Posters:
- Custom objects and posters for environmental design, stored under energy posters and similar folders.
## Instructions to Run the Project
Follow these steps to successfully run the Unity project:
### Setup Unity:
- Ensure Unity 2020.3.3f1 or a compatible version is installed on your system.
- Open the Unity Hub and add the project by navigating to its folder.
### Load the Project:
- Once the project is added to Unity Hub, open it in the Unity Editor.
- Navigate to the `Assets > EnvProject` folder in the Project window to locate the primary scenes and assets.
### Play the Scene:
- Open the `OfficeEnvironmentAudioAidsMore` scene (or any other scene you wish to run).
- Click the "Play" button in the Unity Editor to start the simulation.
### Interactions:
- Use the XR Rig for navigation if VR features are enabled.
- Test the triggers such as Room1Trigger, Room2Trigger, and Room3Trigger to ensure proper functionality.
- Observe the interactions involving pickable objects, such as PickableBooks and BookPlacement.
### Debugging:
- Use the Console window in Unity to monitor logs and errors.
- Ensure that all scripts are correctly attached to GameObjects in the scene.
## Additional Notes
> [!IMPORTANT]
> - Ensure all necessary assets are loaded in the `Assets > EnvProject` folder to avoid missing references.
> - For VR-specific features, make sure the XR Rig is properly configured and connected to compatible hardware.
> - Audio aids and environmental settings can be adjusted through the Inspector window.
