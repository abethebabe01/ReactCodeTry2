export type Bowler = {
  bowlerId: number;
  bowlerLastName?: string;
  bowlerFirstName?: string;
  bowlerMiddleInit?: string;
  bowlerAddress?: string;
  bowlerCity?: string;
  bowlerState?: string;
  bowlerZip?: string;
  bowlerPhoneNumber?: string;
  teamId?: number;
  bowlerScores: BowlerScore[];
  team?: Team | null;
  teamName: string;
};

interface BowlerScore {
  // Define properties of BowlerScore if needed
}

interface Team {
  // Define properties of Team if needed
}

export default Bowler;
