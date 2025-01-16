# Enhancing Energy Conservation Behaviors Through Audiovisual and Social Cues in Virtual Reality
This repository contains Unity VR project and the associated information for the research on 'Enhancing Energy Conservation Behaviors Through Audiovisual and Social Cues in Virtual Reality'. The Unity project includes an indoor office environment with three types of intervention cues to encourage energy conservation actions within the VR environment.

### Layout of the Office Space
In this study, we investigated the efficacy of three intervention methods i.e. audio announcements, visual posters, and social cues from Non-Player Characters (NPCs)—in influencing energy conservation behaviors within a VR simulation of an indoor office environment. The office space includes 3 rooms, a storeroom, a central hall and a lift for entry/exit to the office space:

![](https://github.com/user-attachments/assets/4c618dd7-0655-4c73-a4ac-b2f7c7d8161b)

### Inside the VR
The following video shows the office environment and how it looks in VR. In this sample video, the different types of energy conservation posters are shown. It also shows how the user accomplishes a task within the office environment:

https://github.com/user-attachments/assets/daa8ab8b-233a-459e-a9a5-a4d1f88c4c30

### Data Files
A between-groups user study involving a total of 60 voluntary participants was conducted, consisting of 34 females and 26 males. The users were divided into three groups - audio announcements, visual posters and NPC intervention. Two separate questionnaires were administered (before and after VR exposure) each having a different set of questions in each of the cognitive, connative and affective domains. The `Data Files` folder contains the three excel sheets with user data in the form of average scores for each domain in both pre and post exposure questionnaire and the corresponding PEB scores.

# Unity Project
This project is developed in Unity 2020.3.3f1 with the following Assets and components: 
## Assets Used
The project is structured with assets stored under the `Assets > EnvProject` folder. 
### Scenes:
The project includes a separate scene for each type of intervention cues. These include 
- `OfficeEnvironmentAudioAidsMore`
- `OfficeEnvironmentVisualAidsLessDense`
- `OfficeEnvironmentNPCIntervention`, etc.

All the scenes are listed in the project hierarchy.

Scene name includes information about the intervention cues e.g. `OfficeEnvironmentVisualAidsLessDense` indicates that this scene has visual posters as intervention cues and their density across the environment is low, `OfficeEnvironmentAudioAidsMore` indicates that this scene utilizes periodic audio annoucements as intervention cues with high frequency of repetition. The scenes are:
### Scripts:
Custom scripts have been created for `Announcements` (to control the frequencies of audio announcements), `NPCIntervention` (implements the NPC intervention behavior if a user fails to turn the lights off upon exit from a room) and additional scripts relevant to scene management and interaction.
### Audios:
- Background sound effects stored in the `Assets > EnvProject > Audios` folder.
- Voice clips such as:
  - "If you are the last one, turn off the lights."
  - "Please turn off the lights when not in use."
### Models and Posters:
- Custom objects and posters for environmental design, stored under `Assets > EnvProject > energy posters` and similar folders.
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
- Test the triggers such as `Room1Trigger`, `Room2Trigger,` and `Room3Trigger` to ensure proper functionality.
- Observe the interactions involving pickable objects, such as `PickableBooks` and `BookPlacement`.
### Debugging:
- Use the Console window in Unity to monitor logs and errors.
- Ensure that all scripts are correctly attached to GameObjects in the scene.
## Additional Notes
> [!IMPORTANT]
> - Ensure all necessary assets are loaded in the `Assets > EnvProject` folder to avoid missing references.
> - For VR-specific features, make sure the XR Rig is properly configured and connected to compatible hardware.
> - Audio aids and environmental settings can be adjusted through the Inspector window.
