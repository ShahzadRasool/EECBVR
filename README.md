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
The Unity C# scripts designed for an immersive Virtual Reality (VR) experience. Each script plays a crucial role in creating an interactive and engaging VR environment:
#### Announcement.cs
Handles audio announcements in the VR environment, playing them in a loop with a specified delay and duration. The script ensures announcements are periodically repeated to guide or inform the player.
#### BookHolderSceneCasual.cs
Manages the interaction of placing virtual books into designated holders, validating correct placements, and providing visual cues. When all books are correctly placed, it triggers environmental changes, such as turning off lights and highlighting the next objective.
#### BooksHolder.cs
Facilitates book placement mechanics with feedback for both correct and incorrect placements in the VR scene. On successful completion of the task, the script initiates transitions to new gameplay states, such as lighting changes or task completion notifications.
#### FinalCharacterController.cs
Guides the player to the exit in a VR setting by monitoring progress and triggering directional cues, such as arrow indicators or audio guidance. It activates the final sequence when all gameplay conditions are met, creating a smooth progression experience.
#### FinalTrigger.cs
Displays a celebratory "Congratulations" message when the player interacts with the final trigger zone. This script enhances task completion feedback, ensuring players feel rewarded in the VR environment.
#### HallTrigger.cs
Detects when the player enters or exits specific areas, such as a hall, and updates the behavior of non-player characters (NPCs) accordingly. This adds context-aware interactions and dynamic NPC responses in the VR scene.
#### LightsController.cs
Controls room lighting in the VR environment, allowing for toggling lights on/off and dynamically changing bulb colors. The script also interacts with other systems, ensuring lighting contributes to guiding and immersing the player.
#### MyDestination.cs
Manages interactions when the player reaches specific destinations, triggering NPC animations, dialogue, and movement. It creates a sense of realism in the VR experience by enabling NPC reactions based on player actions.
#### NPCIntervention.cs
Oversees NPC behaviors such as following the player, initiating conversations, or reacting to proximity. The script adds dynamic interactions through animations and audio, enhancing the sense of immersion and engagement.

### Asset Integration and Customization
The VR environment is built using a selection of assets from the Unity Asset Store, which were customized to deliver an interactive and cohesive experience optimized for virtual reality. These assets were tailored to meet the specific needs of the project and enhance user immersion.
#### Simple Office Interiors - Cartoon Assets (S. Studios, 2023)
- This asset provided the core elements for designing vibrant, cartoon-style office interiors.
- Customizations included adjusting object placements, modifying interaction properties, and fine-tuning lighting to ensure a VR-optimized experience.
- The asset can be accessed through [3D package Unity](https://assetstore.unity.com/packages/3d/)

#### VR Interaction Framework (B. N. Games, 2023)
- This framework formed the backbone of the VR interaction system, enabling core functionalities like object pickup, teleportation, and gesture recognition.
- Customization involved refining gameplay mechanics, enhancing object physics, and adjusting interactions to align with research-specific scenarios.
- The asset can be accessed through [Unity Systems](https://assetstore.unity.com/packages/templates/systems/)

#### Population System PRO (AGLOBEX, 2018)
- This asset was used to populate the VR environment with dynamic NPCs, each exhibiting realistic behaviors and animations.
- Custom modifications included tailoring NPC dialogue, movement, and responses based on proximity to the player and interactions, further enhancing the immersion.
- The asset can be accessed through URL: [Unity Characters](https://assetstore.unity.com/packages/3d/characters/)

Additionally, custom-designed posters, audio elements, and NPC interventions were strategically placed throughout the environment to augment the interactive experience. These customizations, combined with tailored scripts, collectively form the foundation of an immersive VR environment that aligns with the goals of the project.

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
