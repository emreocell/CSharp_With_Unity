namespace CSharp.Metods{
    public struct Player{
        public int Lives;
        public string Name;

        private int score;

            public void SetScore(int score){
                this.score=score;
            }

            public int GetScore(){
                return this.score;
            }
    }
}