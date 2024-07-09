[System.Serializable]
public class SettingsData : IData<SettingsData>
{
    public float MusicVolume { get; set; }
    public float SFXVolume { get; set; }
    public int ResolutionIndex { get; set; }
    public int QualityIndex { get; set; }
    public int LanguageIndex { get; set; }
    public bool FullScreen { get; set; }
    public bool Vsync { get; set; }

    /// <summary>
    /// Default constructor of the class.
    /// </summary>
    public SettingsData()
    {
        MusicVolume = 100f;
        SFXVolume = 100f;
        ResolutionIndex = 0;
        QualityIndex = 0;
        LanguageIndex = 0;
        FullScreen = true;
        Vsync = true;
    }

    /// <summary>
    /// Custom constructor of the class.
    /// </summary>
    public SettingsData(float MusicVolume,
                        float SFXVolume,
                        int ResolutionIndex,
                        int QualityIndex,
                        int LanguageIndex,
                        bool FullScreen,
                        bool Vsync)
    {
        this.MusicVolume = MusicVolume;
        this.SFXVolume = SFXVolume;
        this.ResolutionIndex = ResolutionIndex;
        this.QualityIndex = QualityIndex;
        this.LanguageIndex = LanguageIndex;
        this.FullScreen = FullScreen;
        this.Vsync = Vsync;
    }

    /// <summary>
    /// Get the settings data of the current UI elements.
    /// </summary>
    /// <returns>The settings data.</returns>
    public SettingsData GetData()
    {
        MusicVolume = SettingsController.Instance.MusicSetting.Slider.value;
        SFXVolume = SettingsController.Instance.SFXSetting.Slider.value;
        ResolutionIndex = SettingsController.Instance.ResolutionSetting.CurrentIndex;
        QualityIndex = SettingsController.Instance.QualitySetting.CurrentIndex;
        LanguageIndex = SettingsController.Instance.LanguageSetting.CurrentIndex;
        FullScreen = SettingsController.Instance.FullScreen.isOn;
        Vsync = SettingsController.Instance.Vsync.isOn;
        return new SettingsData(MusicVolume,
                                SFXVolume,
                                ResolutionIndex,
                                QualityIndex,
                                LanguageIndex,
                                FullScreen,
                                Vsync);
    }

    /// <summary>
    /// Set the settings data on the current UI elements.
    /// </summary>
    public void SetData()
    {
        SettingsController.Instance.MusicSetting.Slider.value = MusicVolume;
        SettingsController.Instance.SFXSetting.Slider.value = SFXVolume;
        SettingsController.Instance.ResolutionSetting.CurrentIndex = ResolutionIndex;
        SettingsController.Instance.QualitySetting.CurrentIndex = QualityIndex;
        SettingsController.Instance.LanguageSetting.CurrentIndex = LanguageIndex;
        SettingsController.Instance.FullScreen.isOn = FullScreen;
        SettingsController.Instance.Vsync.isOn = Vsync;

    }
}
