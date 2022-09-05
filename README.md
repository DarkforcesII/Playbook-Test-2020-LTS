# Playbook Test 2020 LTS

## Testing in VR
Make sure to clone the repo and open in Unity 2020.3.38. Once inside, make sure the sample project is opened, you'll notice a button in World Space that says spawn cube. The project is automatically set up to work in VR while targeting the Quest. You can either try in play mode or build to the Quest. You should be able to press the button by clicking the back trigger on the right controller. From there, the Cube transform will automatically map to your controller movement. You can also adjust the scale by hitting either A or B on the controller.

## Testing with Mouse and Keyboard
You also have the option to move and adjust the cube with your mouse and keyboard. The first step step will require diabling the VR Canvas in the editor. From there you should enable and expand the Canvas in the Hierarchy. Select the Object Manager and scroll down to the section in the inspector that shows the Cube Spawner Button within the Spawn Cube Script. By defautlt, the VR Button should be referenced but you'll want to drag in the button from the regular canvas for that button to work. Also make sure to disable the UI Helpers object in the Hierarchy. You should now be able to click on the button while in playmode. The last step is to select the instantiated cube in the hierarchy and check the box within the cube movement script that says is headset off. Now if you click on the mouse while holding A, you can drag it around. If you hold S and click, you can change the rotation. Finally if you click and move the scroll wheel, you can adjust the scale of the cube. 

### Quick Note
Make sure the headset is disconnected from computer when testing for mouse and keyboard.
 
