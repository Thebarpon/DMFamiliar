using RedScarf.EasyCSV;
using TMPro;
using UnityEngine;

public class LocalizationManager : MonoBehaviour
{
    [SerializeField] TextAsset _localization;
    static private CsvTable _localizationExcelSheet;
    static private ELanguage _currentLanguage;

    // Start is called before the first frame update
    void Start()
    {
        CsvHelper.Init();
        _localizationExcelSheet = CsvHelper.Create(_localization.text, _localization.name);
    }

    static public void RegisterToLocalization(string key, TextMeshProUGUI text)
    {
        bool searching = true;
        int iteration = 0;
        while (searching)
        {
            if (_localizationExcelSheet.Read(0, iteration) == "Fin")
            {
                searching = false;
            }
            if (_localizationExcelSheet.Read(0, iteration) == key)
            {
                text.text = _localizationExcelSheet.Read((int)_currentLanguage, iteration);
            }
        }

    }

    static public void SetLanguage(ELanguage newLanguage)
    {
        _currentLanguage = newLanguage;
    }
    public enum ELanguage
    {
        English,
        Francais,
        Count
    }
}
