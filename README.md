# Snakes and Ladders
Изработено од Кристијан Крстевски, Марко Ивановски и Филип Кралевски
## 1. Опис
![Alt text](https://github.com/KFilip123/Snake-Ladder/blob/master/Snake%20Ladder/Resources/title-removebg-preview.png)
<br/>
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
Оааа форма е главната почетна форма која има улога како мени.

![Alt text](https://github.com/KFilip123/Snake-Ladder/blob/master/Snake%20Ladder/Resources/SS1.png)

Насловот е едноставна <b>.png слика</b> и одма под насловот има 2 копчиња:
<ul>
        <li>
                <b>START</b> - При клик на ова копче се уклучува <b>Form2</b> кој ве упатува кон главната игра. 
        </li>
        <li>
                <b>HOW TO PLAY</b> - При клик на ова копче се појавува <b>Form3</b> кој е упатство за играње слично на веќе напишаното
        </li>
</ul>
Како што спомнавме, за да се започне игра <b>textbox</b> полињата мора да се пополните, и за справување на тој проблем, поставен е <b>error provider</b> кој не дозволува да е празно полето.
<br/>

## 3.3 Form2.cs
Оваа форма е самата игра Snakes and Ladders. 

![Alt text](https://github.com/KFilip123/Snake-Ladder/blob/master/Snake%20Ladder/Resources/SS3.png)

Голем дел од формата е табелата за играње на која има 30 полиња. Играчите почнуваат на поле 1 и победува првиот играч што ќе стигне до поле 30. Од десната страна ќе ги забележите имињата на играчите, коцката и 2 копчиња:
<ul>
        <li>
                <b>RESET</b> - При клик на ова копче се ресетира таблата и играчите почнуваат започнуваат пак од првото поле. 
        </li>
        <li>
                <b>CLOSE</b> - При клик на ова копче се исклучува играта и се враќате на <b>Form1</b>
        </li>
</ul>
При завршување на играта постои опција повторно да се игра која ја користи истата метода од копчето <b>RESET</b>.

```
private void ResetGame() {
        pbPlayerOne.Location = new Point(47, 358);
        pbPlayerTwo.Location = new Point(47, 394);
        PlayerOneLocation = 0;
        PlayerTwoLocation = 0;

        playerTurn = false;
        playerCounter = 1;
        PlayersLocationClass.PlayerOneMove(PlayerOneLocation, pbPlayerOne);
        PlayersLocationClass.PlayerTwoMove(PlayerTwoLocation, pbPlayerTwo);

        btnRoll.Enabled = true;
}
```

## 3.4 Form3.cs
Последната форма, <b>Form3</b>, се користи за да ги излистаме правилата на играта.

![Alt text](https://github.com/KFilip123/Snake-Ladder/blob/master/Snake%20Ladder/Resources/SS2.png)

Оваа форма е доста едноставна, и е составена од:
<ul>
        <li>
                <b>Labels</b> - Лабели од текст за да се печатат правилата на играта
        </li>
        <li>
                <b>Picturebox</b> - Слики од елеметни од играта за полесно разбирање на правилата
        </li>
        <li>
                <b>Button</b> - Копче <b>Back</b> на крај од формата за да се вратите на <b>Form1</b>
        </li>
</ul>
Правилата на играта се наведени погоре во точката [Како се игра](#2-како-се-игра).

## 4. Version Control
За контрола на верзија користевме Git, и проектот е прикачен на Github за лесен пристап до него. За изработка на проектот сите се поделивме одреден дел и работевме само во <b>master</b> гранка за да немаме никакви конфликти и проблеми. 
