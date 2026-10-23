static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake && archerIsAwake && prisonerIsAwake)
            return true;
        else if (knightIsAwake && !archerIsAwake && !prisonerIsAwake)
            return true;
        else if (!knightIsAwake && archerIsAwake && !prisonerIsAwake)
            return true;
        else if (!knightIsAwake && !archerIsAwake && prisonerIsAwake)
            return true;
        else if (!knightIsAwake && archerIsAwake && prisonerIsAwake)
            return true;
        else if (knightIsAwake && !archerIsAwake && prisonerIsAwake)
            return true;
        else if (knightIsAwake && archerIsAwake && !prisonerIsAwake)
            return true;
        
        return false;
        
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (prisonerIsAwake && !archerIsAwake)
            return true;
        else
            return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {        
        if (knightIsAwake && archerIsAwake && prisonerIsAwake && petDogIsPresent)
            return false;
        else if (knightIsAwake && archerIsAwake && prisonerIsAwake && !petDogIsPresent)
            return false;
        else if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent)
            return true;
        else if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake && !petDogIsPresent)
            return false;
        else if (!knightIsAwake && !archerIsAwake && prisonerIsAwake && (petDogIsPresent || !petDogIsPresent))
            return true;
        else if (!knightIsAwake && archerIsAwake && !prisonerIsAwake && (petDogIsPresent || !petDogIsPresent))
            return false;
        else if (knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent)
            return true;
        else if (knightIsAwake && !archerIsAwake && !prisonerIsAwake && !petDogIsPresent)
            return false;
        else if (!knightIsAwake && archerIsAwake && prisonerIsAwake && !petDogIsPresent)
            return false;
        else if (knightIsAwake && !archerIsAwake && prisonerIsAwake && petDogIsPresent)
            return true;
        else if (knightIsAwake && !archerIsAwake && prisonerIsAwake && !petDogIsPresent)
            return false;
        else if (knightIsAwake && archerIsAwake && !prisonerIsAwake && (petDogIsPresent || petDogIsPresent))
            return false;

        return false;
    }
}
