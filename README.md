# Snakes and Ladders
Изработено од Кристијан Крстевски, Марко Ивановски и Филип Кралевски
## 1. Опис
![Alt text](https://github.com/KFilip123/Snake-Ladder/blob/master/Snake%20Ladder/Resources/title-removebg-preview.png)
<br>
<b>Snakes and Ladders</b> е стара друштвена игра која одлучивме да ја искористиме за нашиот проект. Овој проект ја симулира <i>традиционалната игра</i>, каде играчите фрлаат коцка за да се движат низ таблата, наидувајќи на змии кои ги испраќаат назад и скали што ги унапредуваат напред. Првиот играч што ќе стигне до последното поле победува. Со овој проект го покажавме и го подобривме нашeте знаење во објектно-ориентираните програмски принципи, вклучувајќи и битна логика на играта имплементирани со јазикот <b>C#</b> во <b>Windows Forms</b>.
## 2. Како се игра
Играта е доста едноставна за играње, и во самиот проект има форма која ги објаснува правилата. Пред да се започне со играње мора да ги внесете имињата на играшите во <b>textbox</b> полињата. Со кликање на копчето <b>Start</b> играта започнува. <span style="color: blue">PlayerOne</span> секогаш почнува прв, и ја врти коцката која му дава вредност на колку полиња ќе се движи(од 1 до 6). После него, коцката ја врти <span style="color: red">PlayerTwo</span> и така до крај на играта додека некој од играчите не победи. Како што веќе спомнавме на таблата има змии кој што го спуштаат играчот на пониско поле, и скали кои што го унапредуваат повисоко. По завршување на играта, постои можност за да се започне ноа игра која ја ресетира таблата, или да се исклучи и да се вратите на главното мени.
## 3. Структура 
Проектот е едноставен и содржи само 1 класа со 3 форми, кои ќе ги објасниме детално.
## 3.1 PlayersLocationClass.cs
Оваа класа има 2 методи која ја обележува секоја точка на движење на табелата. Направена е со <b>switch case</b> поради тоа што се повеќе улови и <b>if else</b> би било понапорно.
### 3.1.1 PlayerOne
```
public static void PlayerOneMove(int PlayerLocation, PictureBox pbPlayerOne)
        {
            switch (PlayerLocation)
            {
                case 1:
                    pbPlayerOne.Location = new Point(161, 358);
                    break;
                case 2:
                    pbPlayerOne.Location = new Point(242, 355);
                    break;
                case 3:
                    pbPlayerOne.Location = new Point(327, 359);
                    break;
                case 4:
                    pbPlayerOne.Location = new Point(373, 355);
                    break;
                ...
                ...
                ...
                case 27:
                    pbPlayerOne.Location = new Point(331, 25);
                    break;
                case 28:
                    pbPlayerOne.Location = new Point(412, 35);
                    break;
                case 29:
                    pbPlayerOne.Location = new Point(450, 25);
                    break;
            }
        }
```
### 3.1.2 PlayerTwo
```
public static void PlayerTwoMove(int PlayerLocation, PictureBox pbPlayerTwo)
        {
            switch (PlayerLocation)
            {
                case 1:
                    pbPlayerTwo.Location = new Point(128, 388);
                    break;
                case 2:
                    pbPlayerTwo.Location = new Point(211, 388);
                    break;
                case 3:
                    pbPlayerTwo.Location = new Point(285, 388);
                    break;
                case 4:
                    pbPlayerTwo.Location = new Point(412, 401);
                    break;
                ...
                ...
                ...
                case 27:
                    pbPlayerTwo.Location = new Point(304, 76);
                    break;
                case 28:
                    pbPlayerTwo.Location = new Point(381, 67);
                    break;
                case 29:
                    pbPlayerTwo.Location = new Point(450, 76);
                    break;

            }
        }
```
## 3.2 Form1.cs

## 3.3 Form2.cs

## 3.4 Form3.cs

## 4. Version Control
За контрола на верзија користевме Git, и проектот е прикачен на Github за лесен пристап до него. За изработка на проектот сите се поделивме одреден дел и работевме само во <b>master</b> гранка за да немаме никакви конфликти и проблеми. 
