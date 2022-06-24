// Annalyn's Infiltration
using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {

        return !knightIsAwake;
        // Cannot execute fast attack if knight is awake
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {

        return knightIsAwake || archerIsAwake || prisonerIsAwake;
		// cannot spy if everyone is sleeping. At least 1 person should awake.
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
 
        return prisonerIsAwake && !archerIsAwake;
		// prisoner can signal if archer is leeping and prisoner is awake
		// Cannot signal prisoner if archer and prisoner are both sleeping
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {

        return (!archerIsAwake && petDogIsPresent ) || (prisonerIsAwake && !knightIsAwake && !archerIsAwake);
        
		// if dog is absent and acher is awake cannot free prisoner
		// only prisoner is awake and others are sleeping can free prisoner

    }
}