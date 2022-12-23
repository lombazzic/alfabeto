using System;
// write in 2019 by maurizio.conti@fablabromagna.org

public static class Alfabeto
{
    public static bool Verifica(string input)
    {
        string alfabeto = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string alfa= "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
        bool p=false;
        for(int j=0; j<alfabeto.Length; j++)
        {
            for(int i=0; i<alfa.Length; i++)
            {
                if(alfa[i]==alfabeto[j])
                {
                    p=true;
                    break;
                }
                else
                {
                    p=false;  
                             
                }
            }  
                   
        }
        return p;  
    }
}
