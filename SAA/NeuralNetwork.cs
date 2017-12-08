/**C# deployment code of Neural Networks Model**/

/**==========================================================================
Before running the C# deployment code please read the following.

 STATISTICA variable names will be exported as-is into the C# deployment script;
please verify the resulting script to ensure that the variable names follow the C#
naming conventions and modify the names if necessary.

==========================================================================**/

using System;
using System.Windows.Forms;
using System.Collections.Generic;




public class NeuralNetwork

{

   public static string[] analyse(List<double> list)

   {
        double G1 = list[0];
        double G2 = list[1];
        double G3 = list[2];
        double G4 = list[3];
        double G5 = list[4];
        double G6 = list[5];
        double G7 = list[6];
        double G8 = list[7];
        double G9 = list[8];
        double G10 = list[9];
        double G11 = list[10];
        double G12 = list[11];
        double G13 = list[12];
        double G14 = list[13];

        string __statist_PredCat="";

    string [] __statist_DCats = new string[3];

    __statist_DCats[0]= "Высокий";

    __statist_DCats[1]= "Низкий";

    __statist_DCats[2]= "Средний";



    double __statist_ConfLevel=3.0E-300;



    double[] __statist_max_input = new double[14];

    __statist_max_input[0]= 7.00000000000000e+000;

    __statist_max_input[1]= 5.00000000000000e+000;

    __statist_max_input[2]= 3.00000000000000e+000;

    __statist_max_input[3]= 1.00000000000000e+000;

    __statist_max_input[4]= 8.00000000000000e+000;

    __statist_max_input[5]= 1.00000000000000e+001;

    __statist_max_input[6]= 1.00000000000000e+001;

    __statist_max_input[7]= 1.00000000000000e+001;

    __statist_max_input[8]= 5.00000000000000e+000;

    __statist_max_input[9]= 3.00000000000000e+000;

    __statist_max_input[10]= 3.00000000000000e+000;

    __statist_max_input[11]= 5.00000000000000e+000;

    __statist_max_input[12]= 1.00000000000000e+000;

    __statist_max_input[13]= 1.00000000000000e+000;



    double[] __statist_min_input = new double[14];

    __statist_min_input[0]= 1.00000000000000e+000;

    __statist_min_input[1]= 0.00000000000000e+000;

    __statist_min_input[2]= 0.00000000000000e+000;

    __statist_min_input[3]= 0.00000000000000e+000;

    __statist_min_input[4]= 1.00000000000000e+000;

    __statist_min_input[5]= 5.00000000000000e+000;

    __statist_min_input[6]= 5.00000000000000e+000;

    __statist_min_input[7]= 5.00000000000000e+000;

    __statist_min_input[8]= 0.00000000000000e+000;

    __statist_min_input[9]= 0.00000000000000e+000;

    __statist_min_input[10]= 0.00000000000000e+000;

    __statist_min_input[11]= 0.00000000000000e+000;

    __statist_min_input[12]= 0.00000000000000e+000;

    __statist_min_input[13]= 0.00000000000000e+000;





    double[,] __statist_i_h_wts = new double[7,14];



    __statist_i_h_wts[0,0]=-8.18246975979001e-004;

    __statist_i_h_wts[0,1]=-7.73204691881805e-001;

    __statist_i_h_wts[0,2]=-1.49446170648682e-001;

    __statist_i_h_wts[0,3]=-5.90393764324910e-001;

    __statist_i_h_wts[0,4]=-2.62114118719207e-001;

    __statist_i_h_wts[0,5]=4.70953664999345e-001;

    __statist_i_h_wts[0,6]=2.48212620606323e-001;

    __statist_i_h_wts[0,7]=2.58433892441583e-001;

    __statist_i_h_wts[0,8]=4.37587636168743e-001;

    __statist_i_h_wts[0,9]=4.81949841265192e-001;

    __statist_i_h_wts[0,10]=1.70623956614655e-001;

    __statist_i_h_wts[0,11]=-9.08878843880669e-002;

    __statist_i_h_wts[0,12]=1.66486465635981e-001;

    __statist_i_h_wts[0,13]=4.47332482331000e-001;



    __statist_i_h_wts[1,0]=5.09430603580786e-003;

    __statist_i_h_wts[1,1]=-6.03146579322846e-001;

    __statist_i_h_wts[1,2]=-1.38014942962638e-003;

    __statist_i_h_wts[1,3]=-4.40087951595856e-001;

    __statist_i_h_wts[1,4]=-2.50966791720427e-001;

    __statist_i_h_wts[1,5]=4.01893128325486e-001;

    __statist_i_h_wts[1,6]=3.55090174458914e-001;

    __statist_i_h_wts[1,7]=2.33084470256632e-001;

    __statist_i_h_wts[1,8]=5.45813180536700e-001;

    __statist_i_h_wts[1,9]=4.48139043606531e-001;

    __statist_i_h_wts[1,10]=2.68871990765717e-001;

    __statist_i_h_wts[1,11]=-2.84130396844042e-002;

    __statist_i_h_wts[1,12]=2.65664714019779e-001;

    __statist_i_h_wts[1,13]=3.62145463210242e-001;



    __statist_i_h_wts[2,0]=1.43820542879023e-001;

    __statist_i_h_wts[2,1]=1.56768621031650e+000;

    __statist_i_h_wts[2,2]=1.72165241671790e-001;

    __statist_i_h_wts[2,3]=1.70231809023983e+000;

    __statist_i_h_wts[2,4]=8.80742440258845e-001;

    __statist_i_h_wts[2,5]=-5.13824368882182e-001;

    __statist_i_h_wts[2,6]=1.02962121363530e-001;

    __statist_i_h_wts[2,7]=-6.78279166157231e-001;

    __statist_i_h_wts[2,8]=-5.58946570996175e-001;

    __statist_i_h_wts[2,9]=-1.12901404980852e+000;

    __statist_i_h_wts[2,10]=7.43963763675858e-001;

    __statist_i_h_wts[2,11]=4.58676737120205e-001;

    __statist_i_h_wts[2,12]=-2.06638105977643e-001;

    __statist_i_h_wts[2,13]=-9.42323764608016e-001;



    __statist_i_h_wts[3,0]=2.22738709845108e-001;

    __statist_i_h_wts[3,1]=-2.30685263085148e-001;

    __statist_i_h_wts[3,2]=-2.64927055778854e-001;

    __statist_i_h_wts[3,3]=-2.23110396428926e-001;

    __statist_i_h_wts[3,4]=-1.14904189122337e-001;

    __statist_i_h_wts[3,5]=-2.17420816216012e-001;

    __statist_i_h_wts[3,6]=1.34192859182085e-001;

    __statist_i_h_wts[3,7]=-2.33617171274512e-001;

    __statist_i_h_wts[3,8]=1.20294667009127e-001;

    __statist_i_h_wts[3,9]=-1.39465624049319e-001;

    __statist_i_h_wts[3,10]=8.80740218702559e-002;

    __statist_i_h_wts[3,11]=4.06265530661310e-001;

    __statist_i_h_wts[3,12]=-9.21589855387882e-002;

    __statist_i_h_wts[3,13]=2.15921429399673e-001;



    __statist_i_h_wts[4,0]=2.56645275233557e-001;

    __statist_i_h_wts[4,1]=-8.13463098619259e-001;

    __statist_i_h_wts[4,2]=-5.13678165539867e-001;

    __statist_i_h_wts[4,3]=-7.36887487341209e-001;

    __statist_i_h_wts[4,4]=-1.21450883072404e-001;

    __statist_i_h_wts[4,5]=1.90157022815425e-001;

    __statist_i_h_wts[4,6]=2.89533600491934e-001;

    __statist_i_h_wts[4,7]=2.71631661530134e-001;

    __statist_i_h_wts[4,8]=-1.63053228951377e-001;

    __statist_i_h_wts[4,9]=-1.25196501674068e-001;

    __statist_i_h_wts[4,10]=-3.05110787245225e-001;

    __statist_i_h_wts[4,11]=-4.21903690951861e-001;

    __statist_i_h_wts[4,12]=-5.07423761126601e-001;

    __statist_i_h_wts[4,13]=1.00789885386889e-001;



    __statist_i_h_wts[5,0]=-2.36168528287512e-001;

    __statist_i_h_wts[5,1]=-4.17254721375716e-001;

    __statist_i_h_wts[5,2]=-8.34747553631045e-002;

    __statist_i_h_wts[5,3]=-2.88661238684930e-001;

    __statist_i_h_wts[5,4]=-8.40709450225355e-002;

    __statist_i_h_wts[5,5]=4.05183765919290e-001;

    __statist_i_h_wts[5,6]=3.53029820450534e-002;

    __statist_i_h_wts[5,7]=3.71877897230720e-001;

    __statist_i_h_wts[5,8]=3.01728214845851e-001;

    __statist_i_h_wts[5,9]=4.08010887869903e-001;

    __statist_i_h_wts[5,10]=-5.17530752547457e-002;

    __statist_i_h_wts[5,11]=-3.23867817473550e-001;

    __statist_i_h_wts[5,12]=1.38501556201429e-001;

    __statist_i_h_wts[5,13]=9.20735155256321e-002;



    __statist_i_h_wts[6,0]=-5.37685846383183e-002;

    __statist_i_h_wts[6,1]=4.01777320740904e-001;

    __statist_i_h_wts[6,2]=2.39532938684998e-001;

    __statist_i_h_wts[6,3]=1.06703840129360e+000;

    __statist_i_h_wts[6,4]=8.67256582483589e-001;

    __statist_i_h_wts[6,5]=3.16266331161543e-001;

    __statist_i_h_wts[6,6]=-8.19070852476030e-002;

    __statist_i_h_wts[6,7]=1.23892012605568e-001;

    __statist_i_h_wts[6,8]=3.41051806318898e-002;

    __statist_i_h_wts[6,9]=-3.12294654527681e-001;

    __statist_i_h_wts[6,10]=7.97791969224732e-001;

    __statist_i_h_wts[6,11]=1.30289979821752e-002;

    __statist_i_h_wts[6,12]=-1.52783026578523e-001;

    __statist_i_h_wts[6,13]=-7.72101164884946e-001;



    double[,] __statist_h_o_wts = new double[3,7];



    __statist_h_o_wts[0,0]=4.34804542821342e-001;

    __statist_h_o_wts[0,1]=5.25107892384012e-001;

    __statist_h_o_wts[0,2]=3.74154798327959e-001;

    __statist_h_o_wts[0,3]=7.95547733686201e-001;

    __statist_h_o_wts[0,4]=6.69936604621024e-001;

    __statist_h_o_wts[0,5]=-6.34296632444825e-001;

    __statist_h_o_wts[0,6]=-1.56400716963263e-001;



    __statist_h_o_wts[1,0]=-7.62045774525479e-001;

    __statist_h_o_wts[1,1]=-6.73102094973290e-001;

    __statist_h_o_wts[1,2]=-7.52885890910825e-002;

    __statist_h_o_wts[1,3]=-9.54872251131793e-001;

    __statist_h_o_wts[1,4]=-1.42849120058285e+000;

    __statist_h_o_wts[1,5]=2.96492029110860e-001;

    __statist_h_o_wts[1,6]=-7.10281939581223e-001;



    __statist_h_o_wts[2,0]=4.04359619709646e-001;

    __statist_h_o_wts[2,1]=1.91919759479588e-001;

    __statist_h_o_wts[2,2]=-2.89534030784575e-001;

    __statist_h_o_wts[2,3]=1.56583399904194e-001;

    __statist_h_o_wts[2,4]=7.63334079559014e-001;

    __statist_h_o_wts[2,5]=3.06074111571035e-001;

    __statist_h_o_wts[2,6]=8.76311271141405e-001;



    double[] __statist_hidden_bias = new double[7];

    __statist_hidden_bias[0]=-7.24607734803300e-002;

    __statist_hidden_bias[1]=5.21378780612654e-002;

    __statist_hidden_bias[2]=-6.01227884068406e-002;

    __statist_hidden_bias[3]=-1.98612610065491e-001;

    __statist_hidden_bias[4]=-1.58987158650592e-001;

    __statist_hidden_bias[5]=-7.47914393969230e-002;

    __statist_hidden_bias[6]=-2.19142842836060e-001;



    double[] __statist_output_bias = new double[3];

    __statist_output_bias[0]=6.77992177957949e-001;

    __statist_output_bias[1]=-1.96856659455415e-001;

    __statist_output_bias[2]=4.57837833560056e-001;



    double[] __statist_inputs = new double[14];



    double[] __statist_hidden = new double[7];



    double[] __statist_outputs = new double[3];

    __statist_outputs[0] = -1.0e+307;

    __statist_outputs[1] = -1.0e+307;

    __statist_outputs[2] = -1.0e+307;



    __statist_inputs[0]=G1;

    __statist_inputs[1]=G2;

    __statist_inputs[2]=G3;

    __statist_inputs[3]=G4;

    __statist_inputs[4]=G5;

    __statist_inputs[5]=G6;

    __statist_inputs[6]=G7;

    __statist_inputs[7]=G8;

    __statist_inputs[8]=G9;

    __statist_inputs[9]=G10;

    __statist_inputs[10]=G11;

    __statist_inputs[11]=G12;

    __statist_inputs[12]=G13;

    __statist_inputs[13]=G14;



    double __statist_delta=0;

    double __statist_maximum=1;

    double __statist_minimum=0;

    int __statist_ncont_inputs=14;



    /*scale continuous inputs*/

    for(int __statist_i=0;__statist_i < __statist_ncont_inputs;__statist_i++)

    {

     __statist_delta = (__statist_maximum-__statist_minimum)/(__statist_max_input[__statist_i]-__statist_min_input[__statist_i]);

     __statist_inputs[__statist_i] = __statist_minimum - __statist_delta*__statist_min_input[__statist_i]+ __statist_delta*__statist_inputs[__statist_i];

    }



    int __statist_ninputs=14;

    int __statist_nhidden=7;



    /*Compute feed forward signals from Input layer to hidden layer*/

    for(int __statist_row=0;__statist_row < __statist_nhidden;__statist_row++)

    {

      __statist_hidden[__statist_row]=0.0;

      for(int __statist_col=0;__statist_col < __statist_ninputs;__statist_col++)

      {

       __statist_hidden[__statist_row]= __statist_hidden[__statist_row] + (__statist_i_h_wts[__statist_row,__statist_col]*__statist_inputs[__statist_col]);

      }

     __statist_hidden[__statist_row]=__statist_hidden[__statist_row]+__statist_hidden_bias[__statist_row];

    }



    for(int __statist_row=0;__statist_row < __statist_nhidden;__statist_row++)

    {

      if(__statist_hidden[__statist_row]>100.0)

      {

       __statist_hidden[__statist_row] = 1.0;

      }

      else

      {

       if(__statist_hidden[__statist_row]<-100.0)

       {

        __statist_hidden[__statist_row] = -1.0;

       }

       else

       {

        __statist_hidden[__statist_row] = Math.Tanh(__statist_hidden[__statist_row]);

       }

      }

    }



    int __statist_noutputs=3;



    /*Compute feed forward signals from hidden layer to output layer*/

    for(int __statist_row2=0;__statist_row2 < __statist_noutputs;__statist_row2++)

    {

     __statist_outputs[__statist_row2]=0.0;

    for(int __statist_col2=0;__statist_col2 < __statist_nhidden;__statist_col2++)

      {

       __statist_outputs[__statist_row2]= __statist_outputs[__statist_row2] + (__statist_h_o_wts[__statist_row2,__statist_col2]*__statist_hidden[__statist_col2]);

      }

     __statist_outputs[__statist_row2]=__statist_outputs[__statist_row2]+__statist_output_bias[__statist_row2];

    }





     double __statist_sum = 0.0;

     for(int __statist_ii=0;__statist_ii < __statist_noutputs;__statist_ii++)

    {

     if(__statist_outputs[__statist_ii] > 100)

     {

      __statist_outputs[__statist_ii] = 1.0;

      var __statist_jj = __statist_ii;

      for(int __statist_kk=0;__statist_kk < __statist_noutputs;__statist_kk++)

     {

      if(__statist_kk != __statist_jj)

      {

        __statist_outputs[__statist_kk] = 0.0;

      }

     }

   }

   else

   {

    __statist_outputs[__statist_ii] = Math.Exp(__statist_outputs[__statist_ii]);

   }

  }



     for(int __statist_ii=0;__statist_ii < __statist_noutputs;__statist_ii++)

    {

     __statist_sum =  __statist_sum + __statist_outputs[__statist_ii];

    }



     for(int __statist_ii=0;__statist_ii < __statist_noutputs;__statist_ii++)

    {

     if(__statist_sum >  0)

     {

      __statist_outputs[__statist_ii] = __statist_outputs[__statist_ii]/__statist_sum;

     }

    }





    int __statist_PredIndex=1;

    for(int __statist_ii=0;__statist_ii < __statist_noutputs;__statist_ii++)

    {

     if(__statist_ConfLevel < __statist_outputs[__statist_ii])

     {

      __statist_ConfLevel=__statist_outputs[__statist_ii];

      __statist_PredIndex=__statist_ii;

     }

    }



    __statist_PredCat = __statist_DCats[__statist_PredIndex];

        string[] arr = new string[] { __statist_PredCat, __statist_ConfLevel.ToString() };

        return arr;
   }
}

