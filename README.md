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
The Unity C# scripts designed for an immersive Virtual Reality (VR) experience. All the scripts mentioned below are present here: [scripts](https://github.com/ShahzadRasool/EECBVR/tree/main/Assets/EnvProject/Scripts). Each script plays a crucial role in creating an interactive and engaging VR environment:
#### Announcement.cs
Handles audio announcements in the VR environment, playing them in a loop with a specified delay and duration. The script ensures announcements are periodically repeated to guide or inform the player.
The `Announcement` variable is available in the inspector window where an `AudioSource` file can be chosen. 
```C#
  public AudioSource Annoucnemnt;
```
The following section of code ensures periodic replay of the audio file after `delay` seconds which is also accesible in the inspector window.
```C#
  Annoucnemnt.Play();
  yield return new WaitForSeconds(delay+ClipTime);
  StartCoroutine(wait());
```
#### BookHolderSceneCasual.cs
Manages the interaction of placing virtual books into designated holders, validating correct placements, and providing visual cues. When all books are correctly placed, it triggers environmental changes, such as turning off lights and highlighting the next objective.
An array is initialized to keep track of how many files have been picked and placed at corresponding designated areas.
```C#
  public GameObject[] PickableBooks;
```
The `OnTriggerEnter` is used to check collision of the hand controllers with each book while tags are used to identify if the grabbed book is placed at the designated point.
```C#
  if (this.gameObject.name == "Dest1"){
    Highlighter1.SetActive(false);
    if (other.gameObject.tag == "book1"){
        BookHolder1[0].SetActive(true);
        PickableBooks[0].SetActive(false);
    }
}
```

#### BooksHolder.cs
Facilitates book placement mechanics with feedback for both correct and incorrect placements in the VR scene. On successful completion of the task, the script initiates transitions to new gameplay states, such as lighting changes or task completion notifications. The following courourtine is executed once all books are placed correctly to ensure all arrows/indicators in the scene are deactivated at completion.  
```C#
  if(SceneManager.GetActiveScene().buildIndex == 0){
      turnlightsoffSound.Play();
  }
  TurnLightsOffText.SetActive(true);
  ArrowsLights.SetActive(true);
  yield return new WaitForSeconds(10f);
  TurnLightsOffText.SetActive(false);
```
#### FinalCharacterController.cs
Guides the player to the exit in a VR setting by monitoring progress and triggering directional cues, such as arrow indicators or audio guidance. It activates the final sequence when all gameplay conditions are met, creating a smooth progression experience.
The following code section checks for if all arrows at file and destination are deactivated after successful completion of task, this activates the final trigger that guides the user to the exit.  
```C#
  if (!ArrowsCheck[0].activeSelf && !ArrowsCheck[1].activeSelf && !ArrowsCheck[2].activeSelf && !ArrowsCheck[3].activeSelf && !ArrowsCheck[4].activeSelf && !ArrowsCheck[5].activeSelf && !ArrowsCheck[6].activeSelf){
      StartCoroutine(wait());
      FinalTrigger.SetActive(true);
  }
```
#### FinalTrigger.cs
Displays a celebratory "Congratulations" message when the player interacts with the final trigger zone. This script enhances task completion feedback, ensuring players feel rewarded in the VR environment.
The `CongratulationsText` gameObject is displayed for 3 seconds.
#### HallTrigger.cs
Detects when the player enters or exits specific areas, such as a hall, and updates the behavior of non-player characters (NPCs) accordingly. This adds context-aware interactions and dynamic NPC responses in the VR scene.
When the `Player` tag gameObject enters the hall. 
```C#
  private void OnTriggerEnter(Collider other){
      if (other.tag == "Player"){
          NPCIntervention.Instance.isInHall = true;
      }
  }
```
Similarly, an `OnTriggerExit()` function is used to turn the `inInHall` to false.
#### LightsController.cs
Controls room lighting in the VR environment, allowing for toggling lights on/off and dynamically changing bulb colors. The script also interacts with other systems, ensuring lighting contributes to guiding and immersing the player. A total of 7 lights are placed (one in each room/washroom area/hall/store room).
#### MyDestination.cs
Manages interactions when the player reaches specific destinations, triggering NPC animations, dialogue, and movement. It creates a sense of realism in the VR experience by enabling NPC reactions based on player actions.
#### NPCIntervention.cs
Oversees NPC behaviors such as following the player, initiating conversations, or reacting to proximity. The script adds dynamic interactions through animations and audio, enhancing the sense of immersion and engagement.
THe following part of the script finds the direction of the NPC and its distance from the user and ensures that the NPC walks towards the user and an audio file is played when within range of the user.
```C#
  if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot)){
    TargetDistance = shot.distance;
    if (TargetDistance >= AllowedDistance){
        FollowSpeed = 0.1f;
        NPCAnimator.SetBool("Running", true);
        NPCAnimator.SetBool("talking", false);
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, FollowSpeed);
        NPCInterventionAudio.Play();
        StartCoroutine(CheckAudio());
    }
  }         
```
### Asset Integration and Customization
The VR environment is built using a selection of assets from the Unity Asset Store, which were customized to deliver an interactive and cohesive experience optimized for virtual reality. These assets were tailored to meet the specific needs of the project and enhance user immersion.
#### Simple Office Interiors - Cartoon Assets (S. Studios, 2023)
- This asset provided the core elements for designing vibrant, cartoon-style office interiors.
- Customizations included adjusting object placements, modifying interaction properties, and fine-tuning lighting to ensure a VR-optimized experience.
- The asset can be accessed through [Simple Office Interiror](https://assetstore.unity.com/packages/3d/props/interior/simple-office-interiors-cartoon-assets-38028)

#### VR Interaction Framework (B. N. Games, 2023)
- This framework formed the backbone of the VR interaction system, enabling core functionalities like object pickup, teleportation, and gesture recognition.
- Customization involved refining gameplay mechanics, enhancing object physics, and adjusting interactions to align with research-specific scenarios.
- The asset can be accessed through [Interaction Framework](https://assetstore.unity.com/packages/templates/systems/vr-interaction-framework-161066)

#### Population System PRO (AGLOBEX, 2018)
- This asset was used to populate the VR environment with dynamic NPCs, each exhibiting realistic behaviors and animations.
- Custom modifications included tailoring NPC dialogue, movement, and responses based on proximity to the player and interactions, further enhancing the immersion.
- The asset can be accessed through [Population System](https://assetstore.unity.com/packages/3d/characters/population-system-pro-59820)

Additionally, custom-designed posters, audio elements, and NPC interventions were strategically placed throughout the environment to augment the interactive experience. These customizations, combined with tailored scripts, collectively form the foundation of an immersive VR environment that aligns with the goals of the project.

### Audios:
- Background sound effects stored in the `Assets > EnvProject > Audios` folder.
- Voice clips such as:
  - "If you are the last one, turn off the lights."
  - "Please turn off the lights when not in use."
### Models and Posters:
- Custom objects and posters for environmental design, stored under `Assets > EnvProject > energy posters` and similar folders.
## Instructions to Run the Unity Project
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

# Data Analysis

This project analyzes patterns in energy consumption and conservation behaviors to identify effective strategies for promoting sustainable energy use. The analysis aims to provide insights into how individuals and communities can adopt more energy-efficient practices.

## Features

- Data collection and preprocessing of energy usage data
- Exploratory data analysis of consumption patterns
- Statistical modeling to identify key behavioral factors
- Interactive visualizations of energy conservation trends
- Recommendations for sustainable practices

## Installation

1. Clone the repository:
   ```bash
   git clone <https://github.com/mehakrafiq/EnergyConservationBehaviors.git>
   ```

2. Navigate to the project directory:
   ```bash
   cd EnergyConservationBehaviors
   ```

3. Create a virtual environment:
   ```bash
   python -m venv venv
   ```

4. Activate the virtual environment:

   On Windows:
   ```bash
   venv\Scripts\activate
   ```

   On macOS/Linux:
   ```bash
   source venv/bin/activate
   ```

5. Install dependencies:
   ```bash
   pip install -r requirements.txt
   ```

## Usage

The project contains three main tasks that can be executed in the following order:

1. Data Normalization (Task 1):
   - Open `normalization.ipynb` in Jupyter Notebook
   - Run all cells to normalize the energy consumption data

2. Comparative Analysis (Task 2):
   - Open `comparative_analysis.ipynb` in Jupyter Notebook 
   - Run all cells to analyze patterns and trends
   - There are 2 files comparative_analysis_1a and comparative_analysis_1b need to run both to get the complete analysis

3. Visualization (Task 3):
   - Open `graphs.ipynb` in Jupyter Notebook
   - Run all cells to generate visual insights of the analysis

## Data Sources

All data sources are in the `Data` folder
A report is also made for the statistical analysis in the `Report.docx` file
All the graphs made for the paper are in the `graphs` folder

## Contact
_ Email: Dr Shahzad Rasool (shahzad.rasool@sines.nust.edu.pk)
