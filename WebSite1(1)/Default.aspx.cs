using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{


    private Random _random;

   


    Random random = new Random();
    int carta1, carta2, carta3, carta4, carta5;
    int cpu1, cpu2, cpu3, cpu4, cpu5;



    string jogocpu;
    string carta1nipe;
    string carta2nipe;
    string carta3nipe;
    string carta4nipe;
    string carta5nipe;

    int points;





    protected void Page_Load(object sender, EventArgs e)
    {

     

    }







    int[] carta = new int[10];
    int[] v = new int[5];
    private void SortearCartas()
    {
        //impede repetição
        while (((carta[1] == carta[2]) || (carta[1] == carta[3]) || (carta[1] == carta[4]) || (carta[1] == carta[5])) || ((carta[2] == carta[1]) || (carta[2] == carta[3]) || (carta[2] == carta[4])) || ((carta[2] == carta[5]) || (carta[3] == carta[1])) || ((carta[3] == carta[2]) || (carta[3] == carta[4]) || (carta[3] == carta[5])) || ((carta[4] == carta[1]) || (carta[4] == carta[2]) || (carta[4] == carta[3]) || (carta[4] == carta[5])) || ((carta[5] == carta[1]) || (carta[5] == carta[2]) || (carta[5] == carta[3]) || (carta[5] == carta[4])))
        {
            carta[1] = random.Next(0, 51);
            carta[2] = random.Next(0, 51);
            carta[3] = random.Next(0, 51);
            carta[4] = random.Next(0, 51);
            carta[5] = random.Next(0, 51);
        }


    }







    private void ComparaCartas()
    {


        v[1] = 0;
        v[2] = 13;
        v[3] = 26;
        v[4] = 39;


        int recebe1 = 0;
        int recebe2 = 0;


        SortearCartas();

        // ii = carta1
        //i2 aqui ta no teste
        for (int i2 = 0; i2 <= 51; i2++)
        {

            for (int ii = 1; ii <= 5; ii++)
        {

            // tt = carta 2
            for (int tt = 1; tt <= 5; tt++)
            {

                // caso haja uma comparação da mesma carta
                if (ii != tt)
                {




                    recebe1 = carta[ii];
                    recebe2 = carta[tt];
                    //  Label3.Text = recebe1.ToString();
                    //Label2.Text = recebe2.ToString();

                    

                        for (int i3 = 0; i3 <= 51; i3++)
                        {


                            //Para não comparar a mesma carta
                            if (i2 != i3)
                            {

                            

                                if (recebe1 == i2 && recebe2 == i3 )
                                {

                                    if (recebe1 == 0 || recebe1 == 13 || recebe1 == 26 || recebe1 == 39 )
                                    {


                                        Label3.Text = "PAR DE ÁS";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;
                                    }

                                    else if (recebe1 == 1 || recebe1 == 14 || recebe1 == 27 || recebe1 == 40)
                                    {


                                        Label3.Text = "PAR DE DOIS";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                            tt = 60;
                                    }

                                    else if (recebe1 == 2 || recebe1 == 15 || recebe1 == 28 || recebe1 == 41)
                                    {


                                        Label3.Text = "PAR DE TRÊS";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;
                                    }



                                    else if (recebe1 == 3 || recebe1 == 16 || recebe1 == 29 || recebe1 == 42)
                                    {


                                        Label3.Text = "PAR DE QUATRO";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;
                                    }

                                    else if (recebe1 == 4 || recebe1 == 17 || recebe1 == 29 || recebe1 == 43)
                                    {


                                        Label3.Text = "PAR DE CINCO";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;
                                    }


                                    else if (recebe1 == 5 || recebe1 == 18 || recebe1 == 30 || recebe1 == 44)
                                    {


                                        Label3.Text = "PAR DE SEIS";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;
                                    }


                                    else if (recebe1 == 6 || recebe1 == 19 || recebe1 == 31 || recebe1 == 45)
                                    {


                                        Label3.Text = "PAR DE SETE";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;
                                    }



                                    else if (recebe1 == 7 || recebe1 == 20 || recebe1 == 32 || recebe1 == 46)
                                    {


                                        Label3.Text = "PAR DE OITO";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;
                                    }


                                    else if (recebe1 == 8 || recebe1 == 21 || recebe1 == 33 || recebe1 == 47)
                                    {


                                        Label3.Text = "PAR DE NOVE";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;
                                    }

                                    else if (recebe1 == 9 || recebe1 == 22 || recebe1 == 34 || recebe1 == 48)
                                    {


                                        Label3.Text = "PAR DE DEZ";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;
                                    }

                                    else if (recebe1 == 10 || recebe1 == 23 || recebe1 == 35 || recebe1 == 49)
                                    {


                                        Label3.Text = "PAR DE VALETE";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;
                                    }



                                    else if (recebe1 == 11 || recebe1 == 24 || recebe1 == 36 || recebe1 == 50)
                                    {


                                        Label3.Text = "PAR DE DAMA";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;


                                    }



                                    else if (recebe1 == 12 || recebe1 == 25 || recebe1 == 37 || recebe1 == 51)
                                    {


                                        Label3.Text = "PAR DE REIS";
                                        i3 = 60;
                                        i2 = 60;
                                        ii = 60;
                                        tt = 60;
                                    }


                                }

                            }
                        }
                    }
                }
            }
        }
    }













            

            


            





        




            
        

    

    private void Ganhador() {


        // usarei os pontos

        Label3.Text = points.ToString();




    }

    private void CartasEnlace()
    {











        /////flush nipe







    }







    private void DistribuirCartas()
    {


        carta1 = carta[1];
        carta2 = carta[2];
        carta3 = carta[3];
        carta4 = carta[4];
        carta5 = carta[5];




        // carta 1 copa
        if (carta1 == 0) {

            Image1.ImageUrl = ("~/img/baralho/copas/a de copa.png");
        }
        else if (carta1 == 1)
        {

            Image1.ImageUrl = ("~/img/baralho/copas/2 de copa.png");
        }
        else if (carta1 == 2)
        {

            Image1.ImageUrl = ("~/img/baralho/copas/3 de copa.png");
        }

        else if (carta1 == 3)
        {

            Image1.ImageUrl = ("~/img/baralho/copas/4 de copa.png");
        }
        else if (carta1 == 4)
        {

            Image1.ImageUrl = ("~/img/baralho/copas/5 de copa.png");
        }


        else if (carta1 == 5)
        {

            Image1.ImageUrl = ("~/img/baralho/copas/6 de copa.png");
        }


        else if (carta1 == 6)
        {

            Image1.ImageUrl = ("~/img/baralho/copas/7 de copa.png");
        }

        //else if (carta1 == 7)
        //{

          //  Image1.ImageUrl = ("~/img/baralho/copas/8 de copa.png");
       // }


     //   else if (carta1 == 8)
       // {

        //    Image1.ImageUrl = ("~/img/baralho/copas/9 de copa.png");
        //}


        else if (carta1 == 9)
        {

            Image1.ImageUrl = ("~/img/baralho/copas/10 de copa.png");
        }

        else if (carta1 == 10)
        {

            Image1.ImageUrl = ("~/img/baralho/copas/valete de copa.png");
        }
        else if (carta1 == 11)
        {

            Image1.ImageUrl = ("~/img/baralho/copas/dama de copa.png");
        }

        else if (carta1 == 12)
        {

            Image1.ImageUrl = ("~/img/baralho/copas/rei de copa.png");
        }

        //carta 1 espadas

        else if (carta1 == 13)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/a de espada.png");
        }

        else if (carta1 == 14)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/2 de espada.png");
        }

        else if (carta1 == 15)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/3 de espada.png");
        }

        else if (carta1 == 16)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/4 de espada.png");
        }

        else if (carta1 == 17)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/5 de espada.png");
        }

        else if (carta1 == 18)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/6 de espada.png");
        }

        else if (carta1 == 19)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/7 de espada.png");
        }

        else if (carta1 == 20)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/8 de espada.png");
        }

        else if (carta1 == 21)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/9 de espada.png");
        }

        else if (carta1 == 22)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/10 de espada.png");
        }
        else if (carta1 == 23)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/valete de espada.png");
        }

        else if (carta1 == 24)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/dama de espada.png");
        }
        else if (carta1 == 25)
        {

            Image1.ImageUrl = ("~/img/baralho/espadas/rei de espada.png");
        }

        //carta 1 - ouro

        else if (carta1 == 26)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/a de ouro.png");
        }

        else if (carta1 == 27)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/2 de ouro.png");
        }

        else if (carta1 == 28)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/3 de ouro.png");
        }

        else if (carta1 == 29)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/4 de ouro.png");
        }

        else if (carta1 == 30)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/5 de ouro.png");
        }

        else if (carta1 == 31)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/6 de ouro.png");
        }

        else if (carta1 == 32)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/7 de ouro.png");
        }

        else if (carta1 == 33)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/8 de ouro.png");
        }

        else if (carta1 == 34)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/9 de ouro.png");
        }

        else if (carta1 == 35)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/10 de ouro.png");
        }

        else if (carta1 == 36)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/valete de ouro.png");
        }

        else if (carta1 == 37)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/dama de ouro.png");
        }

        else if (carta1 == 38)
        {

            Image1.ImageUrl = ("~/img/baralho/ouro/rei de ouro.png");
        }

        //carta 1 - paus
  

        else if (carta1 == 39)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/a de paus.png");
        }

        else if (carta1 == 40)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/2 de paus.png");
        }
        else if (carta1 == 41)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/3 de paus.png");
        }

        else if (carta1 == 42)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/4 de paus.png");
        }

        else if (carta1 == 43)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/5 de paus.png");
        }

        else if (carta1 == 44)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/6 de paus.png");
        }

        else if (carta1 == 45)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/7 de paus.png");
        }

        else if (carta1 == 46)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/8 de paus.png");
        }
        else if (carta1 == 47)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/9 de paus.png");
        }

        else if (carta1 == 48)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/10 de paus.png");
        }

        else if (carta1 == 49)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/valete de paus.png");
        }

        else if (carta1 == 50)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/dama de paus.jpg");
        }

        else if (carta1 == 51)
        {

            Image1.ImageUrl = ("~/img/baralho/paus/rei de paus.png");
        }



        //carta2-------------------------------------------------------------



        // carta 1 copa
        if (carta2 == 0)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/a de copa.png");
        }
        else if (carta2 == 1)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/2 de copa.png");
        }
        else if (carta2 == 2)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/3 de copa.png");
        }

        else if (carta2 == 3)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/4 de copa.png");
        }
        else if (carta2 == 4)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/5 de copa.png");
        }


        else if (carta2 == 5)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/6 de copa.png");
        }


        else if (carta2 == 6)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/7 de copa.png");
        }

        else if (carta2 == 7)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/8 de copa.png");
        }


        else if (carta2 == 8)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/9 de copa.png");
        }


        else if (carta2 == 9)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/10 de copa.png");
        }

        else if (carta2 == 10)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/valete de copa.png");
        }
        else if (carta2 == 11)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/dama de copa.png");
        }

        else if (carta2 == 12)
        {

            Image2.ImageUrl = ("~/img/baralho/copas/rei de copa.png");
        }

        //carta 1 espadas

        else if (carta2 == 13)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/a de espada.png");
        }

        else if (carta2 == 14)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/2 de espada.png");
        }

        else if (carta2 == 15)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/3 de espada.png");
        }

        else if (carta2 == 16)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/4 de espada.png");
        }

        else if (carta2 == 17)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/5 de espada.png");
        }

        else if (carta2 == 18)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/6 de espada.png");
        }

        else if (carta2 == 19)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/7 de espada.png");
        }

        else if (carta2 == 20)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/8 de espada.png");
        }

        else if (carta2 == 21)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/9 de espada.png");
        }

        else if (carta2 == 22)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/10 de espada.png");
        }
        else if (carta2 == 23)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/valete de espada.png");
        }

        else if (carta2 == 24)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/dama de espada.png");
        }
        else if (carta2 == 25)
        {

            Image2.ImageUrl = ("~/img/baralho/espadas/rei de espada.png");
        }

        //carta 1 - ouro

        else if (carta2 == 26)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/a de ouro.png");
        }

        else if (carta2 == 27)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/2 de ouro.png");
        }

        else if (carta2 == 28)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/3 de ouro.png");
        }

        else if (carta2 == 29)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/4 de ouro.png");
        }

        else if (carta2 == 30)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/5 de ouro.png");
        }

        else if (carta2 == 31)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/6 de ouro.png");
        }

        else if (carta2 == 32)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/7 de ouro.png");
        }

        else if (carta2 == 33)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/8 de ouro.png");
        }

        else if (carta2 == 34)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/9 de ouro.png");
        }

        else if (carta2 == 35)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/10 de ouro.png");
        }

        else if (carta2 == 36)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/valete de ouro.png");
        }

        else if (carta2 == 37)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/dama de ouro.png");
        }

        else if (carta2 == 38)
        {

            Image2.ImageUrl = ("~/img/baralho/ouro/rei de ouro.png");
        }

        //carta 1 - paus


        else if (carta2 == 39)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/a de paus.png");
        }

        else if (carta2 == 40)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/2 de paus.png");
        }
        else if (carta2 == 41)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/3 de paus.png");
        }

        else if (carta2 == 42)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/4 de paus.png");
        }

        else if (carta2 == 43)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/5 de paus.png");
        }

        else if (carta2 == 44)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/6 de paus.png");
        }

        else if (carta2 == 45)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/7 de paus.png");
        }

        else if (carta2 == 46)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/8 de paus.png");
        }
        else if (carta2 == 47)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/9 de paus.png");
        }

        else if (carta2 == 48)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/10 de paus.png");
        }

        else if (carta2 == 49)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/valete de paus.png");
        }

        else if (carta2 == 50)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/dama de paus.jpg");
        }

        else if (carta2 == 51)
        {

            Image2.ImageUrl = ("~/img/baralho/paus/rei de paus.png");
        }



       // carta3-------------------------------------------------

        // carta 1 copa
       
        if (carta3 == 0)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/a de copa.png");
        }
        else if (carta3 == 1)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/2 de copa.png");
        }
        else if (carta3 == 2)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/3 de copa.png");
        }

        else if (carta3 == 3)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/4 de copa.png");
        }
        else if (carta3 == 4)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/5 de copa.png");
        }


        else if (carta3 == 5)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/6 de copa.png");
        }


        else if (carta3 == 6)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/7 de copa.png");
        }

        else if (carta3 == 7)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/8 de copa.png");
        }


        else if (carta3 == 8)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/9 de copa.png");
        }


        else if (carta3 == 9)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/10 de copa.png");
        }

        else if (carta3 == 10)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/valete de copa.png");
        }
        else if (carta3 == 11)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/dama de copa.png");
        }

        else if (carta3 == 12)
        {

            Image3.ImageUrl = ("~/img/baralho/copas/rei de copa.png");
        }

        //carta 1 espadas

        else if (carta3 == 13)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/a de espada.png");
        }

        else if (carta3 == 14)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/2 de espada.png");
        }

        else if (carta3 == 15)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/3 de espada.png");
        }

        else if (carta3 == 16)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/4 de espada.png");
        }

        else if (carta3 == 17)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/5 de espada.png");
        }

        else if (carta3 == 18)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/6 de espada.png");
        }

        else if (carta3 == 19)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/7 de espada.png");
        }

        else if (carta3 == 20)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/8 de espada.png");
        }

        else if (carta3 == 21)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/9 de espada.png");
        }

        else if (carta3 == 22)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/10 de espada.png");
        }
        else if (carta3 == 23)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/valete de espada.png");
        }

        else if (carta3 == 24)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/dama de espada.png");
        }
        else if (carta3 == 25)
        {

            Image3.ImageUrl = ("~/img/baralho/espadas/rei de espada.png");
        }

        //carta 1 - ouro

        else if (carta3 == 26)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/a de ouro.png");
        }

        else if (carta3 == 27)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/2 de ouro.png");
        }

        else if (carta3 == 28)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/3 de ouro.png");
        }

        else if (carta3 == 29)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/4 de ouro.png");
        }

        else if (carta3 == 30)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/5 de ouro.png");
        }

        else if (carta3 == 31)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/6 de ouro.png");
        }

        else if (carta3 == 32)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/7 de ouro.png");
        }

        else if (carta3 == 33)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/8 de ouro.png");
        }

        else if (carta3 == 34)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/9 de ouro.png");
        }

        else if (carta3 == 35)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/10 de ouro.png");
        }

        else if (carta3 == 36)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/valete de ouro.png");
        }

        else if (carta3 == 37)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/dama de ouro.png");
        }

        else if (carta3 == 38)
        {

            Image3.ImageUrl = ("~/img/baralho/ouro/rei de ouro.png");
        }

        //carta 1 - paus


        else if (carta3 == 39)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/a de paus.png");
        }

        else if (carta3 == 40)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/2 de paus.png");
        }
        else if (carta3 == 41)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/3 de paus.png");
        }

        else if (carta3 == 42)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/4 de paus.png");
        }

        else if (carta3 == 43)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/5 de paus.png");
        }

        else if (carta3 == 44)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/6 de paus.png");
        }

        else if (carta3 == 45)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/7 de paus.png");
        }

        else if (carta3 == 46)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/8 de paus.png");
        }
        else if (carta3 == 47)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/9 de paus.png");
        }

        else if (carta3 == 48)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/10 de paus.png");
        }

        else if (carta3 == 49)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/valete de paus.png");
        }

        else if (carta3 == 50)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/dama de paus.jpg");
        }

        else if (carta3 == 51)
        {

            Image3.ImageUrl = ("~/img/baralho/paus/rei de paus.png");
        }





        // carta4-------------------------------------------------

        // carta 4 copa
        
        if (carta4 == 0)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/a de copa.png");
        }
        else if (carta4== 1)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/2 de copa.png");
        }
        else if (carta4 == 2)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/3 de copa.png");
        }

        else if (carta4 == 3)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/4 de copa.png");
        }
        else if (carta4 == 4)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/5 de copa.png");
        }


        else if (carta4 == 5)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/6 de copa.png");
        }


        else if (carta4 == 6)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/7 de copa.png");
        }

        else if (carta4 == 7)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/8 de copa.png");
        }


        else if (carta4 == 8)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/9 de copa.png");
        }


        else if (carta4 == 9)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/10 de copa.png");
        }

        else if (carta4 == 10)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/valete de copa.png");
        }
        else if (carta4 == 11)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/dama de copa.png");
        }

        else if (carta4 == 12)
        {

            Image4.ImageUrl = ("~/img/baralho/copas/rei de copa.png");
        }

        //carta 1 espadas

        else if (carta4 == 13)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/a de espada.png");
        }

        else if (carta4 == 14)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/2 de espada.png");
        }

        else if (carta4 == 15)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/3 de espada.png");
        }

        else if (carta4 == 16)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/4 de espada.png");
        }

        else if (carta4 == 17)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/5 de espada.png");
        }

        else if (carta4 == 18)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/6 de espada.png");
        }

        else if (carta4 == 19)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/7 de espada.png");
        }

        else if (carta4 == 20)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/8 de espada.png");
        }

        else if (carta4 == 21)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/9 de espada.png");
        }

        else if (carta4 == 22)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/10 de espada.png");
        }
        else if (carta4 == 23)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/valete de espada.png");
        }

        else if (carta4 == 24)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/dama de espada.png");
        }
        else if (carta4 == 25)
        {

            Image4.ImageUrl = ("~/img/baralho/espadas/rei de espada.png");
        }

        //carta 1 - ouro

        else if (carta4 == 26)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/a de ouro.png");
        }

        else if (carta4 == 27)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/2 de ouro.png");
        }

        else if (carta4 == 28)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/3 de ouro.png");
        }

        else if (carta4 == 29)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/4 de ouro.png");
        }

        else if (carta4 ==30)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/5 de ouro.png");
        }

        else if (carta4 == 31)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/6 de ouro.png");
        }

        else if (carta4 == 32)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/7 de ouro.png");
        }

        else if (carta4 == 33)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/8 de ouro.png");
        }

        else if (carta4 == 34)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/9 de ouro.png");
        }

        else if (carta4 == 35)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/10 de ouro.png");
        }

        else if (carta4 == 36)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/valete de ouro.png");
        }

        else if (carta4 == 37)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/dama de ouro.png");
        }

        else if (carta4 == 38)
        {

            Image4.ImageUrl = ("~/img/baralho/ouro/rei de ouro.png");
        }

        //carta 1 - paus


        else if (carta4 == 39)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/a de paus.png");
        }

        else if (carta4 == 40)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/2 de paus.png");
        }
        else if (carta4 == 41)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/3 de paus.png");
        }

        else if (carta4 == 42)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/4 de paus.png");
        }

        else if (carta4 == 43)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/5 de paus.png");
        }

        else if (carta4 == 44)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/6 de paus.png");
        }

        else if (carta4 == 45)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/7 de paus.png");
        }

        else if (carta4 == 46)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/8 de paus.png");
        }
        else if (carta4 == 47)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/9 de paus.png");
        }

        else if (carta4 == 48)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/10 de paus.png");
        }

        else if (carta4 == 49)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/valete de paus.png");
        }

        else if (carta4 == 50)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/dama de paus.jpg");
        }

        else if (carta4 == 51)
        {

            Image4.ImageUrl = ("~/img/baralho/paus/rei de paus.png");
        }






        // carta5-------------------------------------------------

        // carta 5 copa
        if (carta5 == 0)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/a de copa.png");
        }
        else if (carta5 == 1)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/2 de copa.png");
        }
        else if (carta5 == 2)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/3 de copa.png");
        }
        else if (carta5 == 3)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/4 de copa.png");
        }

        else if (carta5 == 4)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/5 de copa.png");
        }
        else if (carta5 == 5)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/6 de copa.png");
        }


        else if (carta5 == 6)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/7 de copa.png");
        }


        else if (carta5 == 7)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/8 de copa.png");
        }

        else if (carta5 == 8)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/9 de copa.png");
        }


        else if (carta5 == 9)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/10 de copa.png");
        }


        else if (carta5 == 10)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/valete de copa.png");
        }

        else if (carta5 == 11)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/dama de copa.png");
        }
        else if (carta5 == 12)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/rei de copa.png");
        }

        else if (carta5 == 13)
        {

            Image5.ImageUrl = ("~/img/baralho/copas/a de espada.png");
        }

        //carta 1 espadas

        else if (carta5 == 14)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/2 de espada.png");
        }

        else if (carta5 == 15)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/3 de espada.png");
        }

        else if (carta5 == 16)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/4 de espada.png");
        }

        else if (carta5 == 17)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/5 de espada.png");
        }

        else if (carta5 == 18)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/6 de espada.png");
        }

        else if (carta5 == 19)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/7 de espada.png");
        }

        else if (carta5 == 20)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/8 de espada.png");
        }

        else if (carta5 == 21)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/9 de espada.png");
        }

        else if (carta5 == 22)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/10 de espada.png");
        }

        else if (carta5 == 23)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/valete de espada.png");
        }
        else if (carta5 == 24)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/dama de espada.png");
        }

        else if (carta5 == 25)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/rei de espada.png");
        }
        else if (carta5 == 26)
        {

            Image5.ImageUrl = ("~/img/baralho/espadas/a de ouro.png");
        }

        //carta 1 - ouro

        else if (carta5 == 27)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/2 de ouro.png");
        }

        else if (carta5 == 28)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/3 de ouro.png");
        }

        else if (carta5 == 29)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/4 de ouro.png");
        }

        else if (carta5 == 30)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/5 de ouro.png");
        }

        else if (carta5 == 31)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/6 de ouro.png");
        }

        else if (carta5 == 32)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/7 de ouro.png");
        }

        else if (carta5 == 33)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/8 de ouro.png");
        }

        else if (carta5 == 34)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/9 de ouro.png");
        }

        else if (carta5 == 35)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/10 de ouro.png");
        }

        else if (carta5 == 36)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/valete de ouro.png");
        }

        else if (carta5 == 37)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/dama de ouro.png");
        }

        else if (carta5 == 38)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/rei de ouro.png");
        }

        else if (carta5 == 39)
        {

            Image5.ImageUrl = ("~/img/baralho/ouro/a de paus.png");
        }

        //carta 1 - paus


        else if (carta5 == 40)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/2 de paus.png");
        }

        else if (carta5 == 41)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/3 de paus.png");
        }
        else if (carta5 == 42)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/4 de paus.png");
        }

        else if (carta5 == 43)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/5 de paus.png");
        }

        else if (carta5 == 44)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/6 de paus.png");
        }

        else if (carta5 == 45)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/7 de paus.png");
        }

        else if (carta5 == 46)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/8 de paus.png");
        }

        else if (carta5 == 47)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/9 de paus.png");
        }
        else if (carta5 == 48)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/10 de paus.png");
        }

        else if (carta5 == 49)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/valete de paus.png");
        }

        else if (carta5 == 50)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/dama de paus.png");
        }

        else if (carta5 == 51)
        {

            Image5.ImageUrl = ("~/img/baralho/paus/rei de paus.jpg");
        }

       


    }









    protected void BComparar_Click(object sender, EventArgs e)
    {
        SortearCartas();
        DistribuirCartas();
        CartasEnlace();
        ComparaCartas();


      
 
        //Label1.Text = carta1.ToString();
    


        //_imagens = System.IO.Directory.EnumerateFiles(@"c:\Temp\1", "*.*", System.IO.SearchOption.AllDirectories)
             //   .Where(s => s.ToLower().EndsWith(".png") ||
              //  s.ToLower().EndsWith(".jpg") ||
              //  s.ToLower().EndsWith(".jpeg") ||
              //  s.ToLower().EndsWith(".gif")).ToList();

     //   _exibidas = new List<string>();
      //  _random = new Random();
        
    //    ViewImagens();


    }








}