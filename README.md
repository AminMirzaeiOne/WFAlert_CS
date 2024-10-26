# WFAlertProject

<h2> 👨‍💻 About Project</h2>
Alert message display library in Windows form (light and simple version)<br />

<h2> ⭐ Features</h2>
- Display alert with desired message <br />
- Has light and dark themes <br />
- It has Fill and Border styles <br />
- Four different types of Alert (Success - Error - Warning - Info) <br />
- Ability to support 7 Alert sounds <br />
- <b>The ability to support 13 animations with the help of the WFAnimation library (https://github.com/AminMirzaeiOne/WFAnimations_CS) </b> <br/>

<h2> 🏗 Build Information</h2>
- Made in year = February 2018 <br />
----------------------------------------------- <br />
- .NET Framework =  4.6.2 <br />
- Csharp = Csharp 7.0.0 <br />
- Micrsoft Visual Studio = VS 2015 <br />


<h2> 📜 Program Rules</h2>
1 - All MIT license rules must be followed <br />
2 - The name of the GitHub founder and main developer (aminmirzaeione) should be mentioned <br />

<h2> 💡 How to use</h2>
1 - Add the library (DLL) file to your Windows Forms application via Add Reference <br />
2 - Write the WFAlert namespace in your C# code <br />

```
using WFAlert;
```
3 - Put a button on your form and call its click event <br />
4 - Enter the following code to display an Alert <br />

```
WFAlert.AlertMessage.Show("Success Message", WFAlert.Types.Success,true);
```
5 - The Show method in the AlertMessage class receives three parameters (text message , Alert Type , Close Button Visable)

6 - Enable and disable animation <br />

```
WFAlert.AlertMessage.Animation = true;
```

7 - Changing the Time Step of animations <br />

```
WFAlert.AlertMessage.AlertAnimation.TimeStep = 0.02f;
```

8 - Change animation type <br />

```
WFAlert.AlertMessage.AlertAnimation.Success = WFAlert.Animations.Mosaic;
```

9 - Changing the style of Alerts (Fill and Border Styles) <br />

```
WFAlert.AlertMessage.Style = WFAlert.Styles.Fill;
```

10 - Changing the theme of Alerts (Light and Dark Styles) <br />

```
WFAlert.AlertMessage.Theme = WFAlert.Themes.Dark;
```

11 - Changing and personalizing the text font of Alerts <br />

```
WFAlert.AlertMessage.Font = new Font("Segoe UI", 11, FontStyle.Italic);
```


<h2>🎨Styles and Themes</h2>
<h3>✅Success Alert</h3>
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/6b7e8537-9e0b-4778-8ff9-c3610363ab0b">
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/a186ffc7-5712-46c6-9946-7fbadecbbc2b">
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/beab2a1a-1669-482e-916b-3c8d4a4158c8">
<h3>⚠️Warning Alert</h3>
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/9bece5d8-a1a3-4ff9-9cdd-19efbc1c0395">
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/3e47c079-bee7-4869-954a-1cd7fbe35ef2">
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/adda7949-f97c-41a5-873f-47a18dea8794">
<h3>❗Error Alert</h3>
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/d16fef3c-2994-465c-9a34-50d5bf16b680">
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/bf18fee5-c362-4b9f-afdb-a653f413922c">
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/c60d1d6d-8c31-49ba-864c-a2e739389717">
<h3>ℹInformation Alert</h3>
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/37c816a7-aaf4-45f3-837f-d8d02cd9cf87">
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/9bdae835-d280-49c4-9daa-3e300b0b8f7c">
<img width="250" alt="Capture28" src="https://github.com/user-attachments/assets/87f1abae-c203-4d72-bf91-9a77feaa2448">

