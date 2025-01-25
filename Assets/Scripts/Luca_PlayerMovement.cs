using UnityEngine;

public class HuevoProta {
    public int posX;
    public int deltaX;
    public int posY;
    public int deltaY;

    public HuevoProta(){
        posX= 0;
        posY = 0;
        deltaX = 1;
        deltaY = 1;
    }

    public int getPosX(){return posX;}
    public void setPosX(int newPosition){posX = newPosition;}

    public int getPosY(){return posY;}
    public void setPosY(int newPosition){posY = newPosition;}

    public int getDeltaX(){return deltaX;}
    public void setDeltaX(int newDelta){deltaX = newDelta;}

    public int getDeltaY(){return deltaY;}
    public void setDeltaX(int newDelta){deltaY = newDelta;}
}

public class PlayerMovement
{
    static void Main(string[] args) {
        HuevoProta huevo = new HuevoProta(); 

        console.log(huevo.getPosX()+" "+huevo.getPosY)
    }
}
