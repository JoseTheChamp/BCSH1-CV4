namespace GameLibrary;

// TODO: Vytvořte třídu UpdatedStatsEventArgs, která je potomkem EventArgs
// - a obsahuje vlastnosti (get & init)
// -- int Correct
// -- int Missed
// -- int Accuracy
public class UpdatedStatsEventArgs : EventArgs
{
    public UpdatedStatsEventArgs(int correct, int missed, int accuracy) { 
        this.Corrcet = correct;
        this.Accuracy = accuracy;
        this.Missed = missed;
    }
    public int Corrcet { get; init; }
    public int Missed { get; init; }
    public int Accuracy { get; init; }
}
// TODO: Vytvořte delegát UpdatedStatsEventHandler pro příslušnou událost, využijte výše definované argumenty
    public delegate void UpdatedStatsEventHandler(object sender, UpdatedStatsEventArgs e); //????/

// TODO: Dokončete třídu Stats...
public class Stats
{

    // TODO: Vytvořte vlastnosti určené pro čtení:
    // - int Correct
    // - int Missed
    // - Int Accuracy
    public int Correct { get;}
    public int Missed { get;}
    public int Accuracy { get;}

    private int _accuracy = 0;
    private int _missed = 0;
    private int _correct = 0;

    // TODO: Vytvořte veřejnou událost UpdatedStats (UpdatedStatsEventHandler?)

    public event UpdatedStatsEventHandler UpdatedStats;

    // TODO: Vytvořte veřejnou metodu Update
    // - parametr - bool correctKey - určuje zdali byla stisknuta správná klávesa a jedná se o Correct zásah či o Missed zásah
    // - na základě parametru inkrementujte Correct nebo Missed vlastnost
    // - vypočtěte hodnotu Accuracy jako procentuální přesnost (na základě Correct a Missed, vypočtená hodnota 0-100 %)
    // - vyvolejte událost UpdatedStats a předejte pomocí event args aktuální stav vlastností

    public void Update(bool isCorrect) {
        if (isCorrect)
        {
            _correct++;
        }
        else { 
            _missed++;
        }
        _accuracy = (int)Math.Round(((double)_correct / ((double)_missed + (double)_correct))*100);        //((_correct / (_correct + _missed))*100);
        UpdatedStats.Invoke(this,new UpdatedStatsEventArgs(_correct,_missed,_accuracy));
    }

    // TODO: Vytvořte veřejnou metodu Reset
    // - metoda vynuluje vlasnosti Correct, Missed, Accuracy
    // - metoda nijak nemění stav události UpdatedStats a ani ji nevyvolává

    public void Reset()
    {
        _accuracy = 0;
        _missed = 0;
        _correct = 0;
    }
}
