# PlayFabLoginSample
 
## Description

Login sample using PlayFab's official GitHub authentication class.

## Preparation

1. Download this repository locally.  

1. Refer to the following site and set up PlayFab Editor Extensions.  
https://playfab-master.com/playfab-how-to-start  

1. Run it in Unity. Then the user will be created automatically.

## GameManagerSettings

1. Under the **Contents > TitleData** section of the Game Manager add the value with the key below.

| Key | Value | Remark | 
----|---- |---- 
| Title | GameTitle | Any value is fine |

2. Under the **Player > Someone's player > PlayerData(Title)** section of the Game Manager add the value with the key below.

| Key | Value | Remark | 
----|---- |---- 
| Name | nekojoker | Any value is fine |

***Someone's player*** is an auto-created user.

## Run

1. Return to the unity editor, Run.

1. If the settings are output to the log, you are successful!!

## StepUp

You can set various bool properties from the Inspector of the object to which the PlayFabContoller is attached.  
Try changing these to get various values.

---

## AuthorInfo

Blog: https://playfab-master.com/ (Japanese)  
Twitter: https://twitter.com/nekojoker1234 (Japanese)
