# Snakes and Ladders
Изработено од Кристијан Крстевски, Марко Ивановски и Филип Кралевски
## 1. Опис
![Alt text](https://github.com/KFilip123/Snake-Ladder/blob/master/Snake%20Ladder/Resources/title-removebg-preview.png)
<br>
<b>Snakes and Ladders</b> е стара друштвена игра која одлучивме да ја искористиме за нашиот проект. Овој проект ја симулира <i>традиционалната игра</i>, каде играчите фрлаат коцка за да се движат низ таблата, наидувајќи на змии кои ги испраќаат назад и скали што ги унапредуваат напред. Првиот играч што ќе стигне до последниот квадрат победува. Со овој проект го покажавме и го подобривме нашeте знаење во објектно-ориентираните програмски принципи, вклучувајќи и битна логика на играта имплементирани со јазикот <b>C#</b> во <b>Windows Forms</b>.
## 2. Како се игра

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
                case 5:
                    pbPlayerOne.Location = new Point(488, 356);
                    break;
                case 6:
                    pbPlayerOne.Location = new Point(485, 277);
                    break;
                case 7:
                    pbPlayerOne.Location = new Point(371, 277);
                    break;
                case 8:
                    pbPlayerOne.Location = new Point(290, 279);
                    break;
                case 9:
                    pbPlayerOne.Location = new Point(247, 278);
                    break;
                case 10:
                    pbPlayerOne.Location = new Point(128, 279);
                    break;
                case 11:
                    pbPlayerOne.Location = new Point(37, 283);
                    break;
                case 12:
                    pbPlayerOne.Location = new Point(81, 196);
                    break;
                case 13:
                    pbPlayerOne.Location = new Point(160, 195);
                    break;
                case 14:
                    pbPlayerOne.Location = new Point(243, 194);
                    break;
                case 15:
                    pbPlayerOne.Location = new Point(289, 195);
                    break;
                case 16:
                    pbPlayerOne.Location = new Point(369, 197);
                    break;
                case 17:
                    pbPlayerOne.Location = new Point(451, 197);
                    break;
                case 18:
                    pbPlayerOne.Location = new Point(451, 111);
                    break;
                case 19:
                    pbPlayerOne.Location = new Point(367, 112);
                    break;
                case 20:
                    pbPlayerOne.Location = new Point(283, 113);
                    break;
                case 21:
                    pbPlayerOne.Location = new Point(204, 110);
                    break;
                case 22:
                    pbPlayerOne.Location = new Point(168, 108);
                    break;
                case 23:
                    pbPlayerOne.Location = new Point(47, 108);
                    break;
                case 24:
                    pbPlayerOne.Location = new Point(88, 25);
                    break;
                case 25:
                    pbPlayerOne.Location = new Point(169, 34);
                    break;
                case 26:
                    pbPlayerOne.Location = new Point(239, 25);
                    break;
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
                case 5:
                    pbPlayerTwo.Location = new Point(450, 401);
                    break;
                case 6:
                    pbPlayerTwo.Location = new Point(485, 317);
                    break;
                case 7:
                    pbPlayerTwo.Location = new Point(400, 310);
                    break;
                case 8:
                    pbPlayerTwo.Location = new Point(332, 317);
                    break;
                case 9:
                    pbPlayerTwo.Location = new Point(246, 312);
                    break;
                case 10:
                    pbPlayerTwo.Location = new Point(160, 313);
                    break;
                case 11:
                    pbPlayerTwo.Location = new Point(83, 318);
                    break;
                case 12:
                    pbPlayerTwo.Location = new Point(50, 233);
                    break;
                case 13:
                    pbPlayerTwo.Location = new Point(125, 231);
                    break;
                case 14:
                    pbPlayerTwo.Location = new Point(202, 236);
                    break;
                case 15:
                    pbPlayerTwo.Location = new Point(293, 232);
                    break;
                case 16:
                    pbPlayerTwo.Location = new Point(368, 232);
                    break;
                case 17:
                    pbPlayerTwo.Location = new Point(450, 234);
                    break;
                case 18:
                    pbPlayerTwo.Location = new Point(450, 151);
                    break;
                case 19:
                    pbPlayerTwo.Location = new Point(373, 148);
                    break;
                case 20:
                    pbPlayerTwo.Location = new Point(330, 152);
                    break;
                case 21:
                    pbPlayerTwo.Location = new Point(244, 152);
                    break;
                case 22:
                    pbPlayerTwo.Location = new Point(158, 150);
                    break;
                case 23:
                    pbPlayerTwo.Location = new Point(87, 149);
                    break;
                case 24:
                    pbPlayerTwo.Location = new Point(55, 65);
                    break;
                case 25:
                    pbPlayerTwo.Location = new Point(133, 65);
                    break;
                case 26:
                    pbPlayerTwo.Location = new Point(202, 65);
                    break;
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
